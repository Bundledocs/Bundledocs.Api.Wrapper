Imports Bundledocs.Model

Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim browserLocation As Uri = New Uri(String.Format("https://app.bundledocs.com/auth/oauth2/authorize?response_type=token&client_id={0}&redirect_uri={1}&state={2}", My.Settings.ClientID, My.Settings.RedirectUri, Guid.NewGuid().ToString("n")))
        wbMain.Url = browserLocation
    End Sub

    Private Sub wbMain_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbMain.DocumentCompleted
        If (e.Url.AbsoluteUri.Contains("access_token")) Then
            Dim sideWithAccessToken As String = e.Url.AbsoluteUri.Split("#").Where(Function(k) k.Contains("access_token")).FirstOrDefault()
            Dim accessTokenParameter As String = sideWithAccessToken.Split("&").Where(Function(k) k.Contains("access_token")).FirstOrDefault()
            Dim accessToken As String = accessTokenParameter.Split("=").Where(Function(k) Not k.Contains("access_token")).FirstOrDefault()

            InitializeApi(accessToken)

        End If
    End Sub

    Private Sub InitializeApi(accessToken As String)
        Dim bundledocsApi As BundledocsApi = BundledocsApi.[New](accessToken)
        Dim user As UserBean = bundledocsApi.Users.Me()

        txtApiMe.Text = user.Email
        txtAccessToken.Text = accessToken

    End Sub
End Class