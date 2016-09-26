namespace Bundledocs.Api.Wrapper.Client
{
    using Bundledocs.Api.Wrapper.Client.Properties;
    using Bundledocs.Model;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Net;
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        private CefSharp.WinForms.ChromiumWebBrowser wbMain;

        public struct OAuthApiCredentials
        {
            public static readonly string ClientId = App.Default.AppID;
            public static readonly string ClientSecret = App.Default.AppSecret;
            public static readonly string RedirectUri = App.Default.AppRedirectUri;
        }

        public FrmMain()
        {
#if DEBUG
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
#endif
            InitializeComponent();
            InitializeComponentInternal();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            wbMain.AddressChanged += WbMain_AddressChanged;
        }

        private void WbMain_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            if (e.Address.Contains("access_token"))
            {
                string sideWithAccessToken = e.Address.Split('#').Where(k => k.Contains("access_token")).FirstOrDefault();
                string accessTokenParameter = sideWithAccessToken.Split('&').Where(k => k.Contains("access_token")).FirstOrDefault();
                string accessToken = accessTokenParameter.Split('=').Where(k => !k.Contains("access_token")).FirstOrDefault();

                InitializeApi(accessToken);

                this.Invoke((Action)delegate
                {
                    txtAccessToken.Text = accessToken;
                });
            }
        }

        private void InitializeApi(string accessToken)
        {
            BundledocsApi bundledocsApi = BundledocsApi.New(accessToken);
            UserBean user = bundledocsApi.Users.Me();

            this.Invoke((Action)delegate
            {
                txtApiMe.Text = JsonConvert.SerializeObject(new { PartitionKey = user.PartitionKey, RowKey = user.RowKey, Email = user.Email }, Formatting.Indented);
            });
        }

        private void InitializeComponentInternal()
        {
            string clientUrl = String.Format("https://app.bundledocs.com/auth/oauth2/authorize?response_type=token&client_id={0}&redirect_uri={1}&state={2}", OAuthApiCredentials.ClientId, OAuthApiCredentials.RedirectUri, Guid.NewGuid().ToString("n"));
            this.wbMain = new CefSharp.WinForms.ChromiumWebBrowser(clientUrl);
            this.wbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowserContainer.Controls.Add(wbMain);
        }
    }
}
