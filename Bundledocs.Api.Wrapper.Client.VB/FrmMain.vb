Imports Bundledocs.Model

Public Class FrmMain
    Dim _bundledocsApi As BundledocsApi

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim browserLocation As Uri = New Uri(String.Format("https://app.bundledocs.com/auth/oauth2/authorize?response_type=token&client_id={0}&redirect_uri={1}&state={2}", My.Settings.ClientID, My.Settings.RedirectUri, Guid.NewGuid().ToString("n")))
        wbMain.Url = browserLocation
    End Sub

    Private Sub wbMain_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbMain.DocumentCompleted
        If (e.Url.AbsoluteUri.Contains("access_token")) Then
            Dim sideWithAccessToken As String = e.Url.AbsoluteUri.Split("#").Where(Function(k) k.Contains("access_token")).FirstOrDefault()
            Dim accessTokenParameter As String = sideWithAccessToken.Split("&").Where(Function(k) k.Contains("access_token")).FirstOrDefault()
            Dim accessToken As String = accessTokenParameter.Split("=").Where(Function(k) Not k.Contains("access_token")).FirstOrDefault()

            InitializeApi(accessToken)
            LoadUser()
        End If
    End Sub

    Private Sub InitializeApi(accessToken As String)
        _bundledocsApi = BundledocsApi.[New](accessToken)
        txtAccessToken.Text = accessToken
    End Sub

    Private Sub LoadUser()
        Dim user As UserBean = _bundledocsApi.Users.Me()
        txtApiMe.Text = user.Email
        lstBundles.Items.Clear()
        For Each brief As Brief In user.Briefs
            lstBundles.Items.Add(brief)
        Next
    End Sub

    Private Sub lstBundles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBundles.SelectedIndexChanged
        If (lstBundles.SelectedItem IsNot Nothing) Then
            Dim selectedBrief As Brief = lstBundles.SelectedItem
            lstSections.Items.Clear()
            For Each briefDocument As BriefDocument In _bundledocsApi.Bundles.Tree(selectedBrief.PartitionKey, selectedBrief.RowKey)
                lstSections.Items.Add(briefDocument)
            Next
        End If
    End Sub

    Private Sub btnChooseFiles_Click(sender As Object, e As EventArgs) Handles btnChooseFiles.Click
        lstDocuments.Items.Clear()
        If (dlgOpenFiles.ShowDialog().Equals(DialogResult.OK)) Then
            lstDocuments.Items.AddRange(dlgOpenFiles.FileNames)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If (lstBundles.SelectedItem IsNot Nothing) Then
            Dim selectedSection As BriefDocument = lstSections.SelectedItem
            For Each fileName As String In lstDocuments.Items
                _bundledocsApi.Documents.Create(selectedSection, fileName)
            Next

            _bundledocsApi.Events.WaitForUploadToComplete(selectedSection.ForeignKey, lstDocuments.Items.Count)

            MessageBox.Show("Upload Complete")
        End If
    End Sub
End Class