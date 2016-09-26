Imports System.IO
Imports Bundledocs.Model

Public Class FrmMain
    Dim _bundledocsApi As BundledocsApi

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'authorize this app to use the users' details
        Dim browserLocation As Uri = New Uri(String.Format("https://app.bundledocs.com/auth/oauth2/authorize?response_type=token&client_id={0}&redirect_uri={1}&state={2}", My.Settings.ClientID, My.Settings.RedirectUri, Guid.NewGuid().ToString("n")))
        wbMain.Url = browserLocation
    End Sub

    Private Sub OAuth2ApiEventListenerUpload(OAuth2ApiEvent As OAuth2ApiEvent)
        Invoke(Sub() lstEventsUpload.Items.Add(OAuth2ApiEvent))
    End Sub
    Private Sub OAuth2ApiEventListenerGenerate(OAuth2ApiEvent As OAuth2ApiEvent)
        Invoke(Sub() lstEventsGenerate.Items.Add(OAuth2ApiEvent))
    End Sub

    Private Sub wbMain_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbMain.DocumentCompleted
        If (e.Url.AbsoluteUri.Contains("access_token")) Then
            'retrieve the access token from the url
            Dim sideWithAccessToken As String = e.Url.AbsoluteUri.Split("#").Where(Function(k) k.Contains("access_token")).FirstOrDefault()
            Dim accessTokenParameter As String = sideWithAccessToken.Split("&").Where(Function(k) k.Contains("access_token")).FirstOrDefault()
            Dim accessToken As String = accessTokenParameter.Split("=").Where(Function(k) Not k.Contains("access_token")).FirstOrDefault()

            'initialize the api with our new access token
            InitializeApi(accessToken)

            'load the accessToken owner
            LoadMe()
        End If
    End Sub

    Private Sub InitializeApi(accessToken As String)
        'retrieve a new BundledocsApi instance with the accessToken
        _bundledocsApi = BundledocsApi.[New](accessToken)
        txtAccessToken.Text = accessToken

        'add some event listeners to the generate and upload process
        AddHandler _bundledocsApi.Events.OAuth2ApiEventUpload, AddressOf OAuth2ApiEventListenerUpload
        AddHandler _bundledocsApi.Events.OAuth2ApiEventGenerate, AddressOf OAuth2ApiEventListenerGenerate
    End Sub

    Private Sub LoadMe()
        'retrieve the user that this instance of the _bundledocsApi relates to
        Dim user As UserBean = _bundledocsApi.Users.Me()

        'display the users' email address
        txtApiMe.Text = user.Email

        'display the users' bundles
        lstBundles.Items.Clear()
        For Each brief As Brief In user.Briefs
            lstBundles.Items.Add(brief)
        Next
    End Sub

    Private Sub LoadReceipts(selectedBundle As Brief)
        'retrieve the generated bundle details
        Dim briefBean As BriefBean = _bundledocsApi.Bundles.Get(selectedBundle.PartitionKey, selectedBundle.RowKey)

        'display the receipts for this bundle
        lstReceipts.Items.Clear()
        For Each briefReceiptBean As BriefReceiptBean In briefBean.BriefReceipts
            lstReceipts.Items.Add(briefReceiptBean)
        Next
    End Sub

    Private Sub lstBundles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBundles.SelectedIndexChanged
        'display the sections from the currently selected bundle
        If (lstBundles.SelectedItem IsNot Nothing) Then
            Dim selectedBundle As Brief = lstBundles.SelectedItem
            lstSections.Items.Clear()

            'a bundles sections are organized in a tree structure; display the root nodes of the section tree
            For Each briefDocument As BriefDocument In _bundledocsApi.Bundles.Tree(selectedBundle.PartitionKey, selectedBundle.RowKey)
                lstSections.Items.Add(briefDocument)
            Next

            'load the receipts for this bundle
            LoadReceipts(selectedBundle)
        End If
    End Sub

    Private Sub btnChooseFiles_Click(sender As Object, e As EventArgs) Handles btnChooseFiles.Click
        'add some document paths to the document list
        lstDocuments.Items.Clear()
        If (dlgOpenFiles.ShowDialog().Equals(DialogResult.OK)) Then
            lstDocuments.Items.AddRange(dlgOpenFiles.FileNames)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'upload the documents into the selected section 
        If (lstSections.SelectedItem IsNot Nothing) Then
            Dim selectedSection As BriefDocument = lstSections.SelectedItem

            'create the current document in the selectedSection
            For Each fileName As String In lstDocuments.Items
                _bundledocsApi.Documents.Create(selectedSection, fileName)
            Next

            'wait for upload to complete; events will be passed to OAuth2ApiEventListener
            _bundledocsApi.Events.WaitForUploadToComplete(selectedSection.ForeignKey, lstDocuments.Items.Count)

            'open bundledocs to allow the user to manage the bundle
            Process.Start("https://login.bundledocs.com")
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'generate the selected bundle
        If (lstBundles.SelectedItem IsNot Nothing) Then
            Dim selectedBundle As Brief = lstBundles.SelectedItem

            'retrieve a briefbean for the selected brief to hold the generate options
            Dim briefBean As BriefBean = BriefBean.FromBrief(selectedBundle)

            'set some instructions for the generate process
            briefBean.IsBriefSectionHeadersIncluded = False
            briefBean.IndexTitleText = "Table of Contents"
            briefBean.IsWatermarked = True
            briefBean.WatermarkType = "Draft"

            'send the bundle to the generate process
            _bundledocsApi.Bundles.Generate(selectedBundle.PartitionKey, selectedBundle.RowKey, briefBean)

            'wait for upload to complete; events will be passed to OAuth2ApiEventListener
            _bundledocsApi.Events.WaitForGenerateToComplete(selectedBundle.RowKey)

            'reload the receipts for this bundle
            LoadReceipts(selectedBundle)
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        'generate the selected bundle
        If (lstReceipts.SelectedItem IsNot Nothing) Then
            Dim selectedReceipt As BriefReceiptBean = lstReceipts.SelectedItem

            'download the selected receipt to stream and create as byte array
            Dim downloadedBundle As Stream = _bundledocsApi.Receipts.Download(selectedReceipt.PartitionKey, selectedReceipt.RowKey)
            Dim downloadedBundleBytes As Byte() = New BinaryReader(downloadedBundle).ReadBytes(downloadedBundle.Length)

            'write the downloaded bundle to disk and open
            Dim tempBundlePath = Path.GetTempFileName() + ".pdf"
            File.WriteAllBytes(tempBundlePath, downloadedBundleBytes)
            Process.Start(tempBundlePath)
        End If
    End Sub
End Class