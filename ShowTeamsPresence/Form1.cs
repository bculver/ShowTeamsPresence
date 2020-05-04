extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;


namespace ShowTeamsPresence
{
    public partial class Form1 : Form
    {
        // Application Registration
        private string _clientID = "<CLIENT-ID>"; // TeamsAppforCollab 

        private Beta.GraphServiceClient _graphClient = null;

        //private List<string> graphScopes = new List<string> { "User.Read","Calendars.Read" };
        private List<string> graphScopes = new List<string> { 
            "User.Read", 
           // "User.ReadBasic.All", 
            "Presence.Read", 
            "Presence.Read.All" };
        //private List<string> graphScopes = new List<string> { "User.ReadBasic.All" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Login();
        }

        public async void Login()
        {
            // Build a client application.
            IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
                        .Create(_clientID)
                        .WithAuthority(AzureCloudInstance.AzurePublic, AadAuthorityAudience.AzureAdMultipleOrgs)
                        .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                        .Build();

            //var authProvider = new UsernamePasswordProvider(publicClientApplication, graphScopes);
            var authProvider = new InteractiveAuthenticationProvider(publicClientApplication, graphScopes);
            // Create an authentication provider by passing in a client application and graph scopes.
            //DeviceCodeProvider authProvider = new DeviceCodeProvider(publicClientApplication, graphScopes);

            // Create a new instance of GraphServiceClient with the authentication provider.
            this._graphClient = new Beta.GraphServiceClient(authProvider);

            Beta.User profile = await this._graphClient.Me.Request().GetAsync();

            this.txtUsername.Text = profile.UserPrincipalName;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetPresence();
        }

        public async void GetPresence()
        {
            var presence = await this._graphClient.Me.Presence
                .Request()
                .GetAsync();

            this.txtPresence.Text = "Activity: " + presence.Activity + "\nAvailability: " + presence.Availability;

            switch (presence.Availability)
            {
                case "Available":
                    this.boxStatus.BackColor = Color.Green;
                    break;
                case "Away":
                    this.boxStatus.BackColor = Color.Yellow;
                    break;
                case "BeRightBack":
                    this.boxStatus.BackColor = Color.Orange;
                    break;
                case "Busy":
                    this.boxStatus.BackColor = Color.Red;
                    break;
                case "DoNotDisturb":
                    this.boxStatus.BackColor = Color.DarkRed;
                    break;
                default:
                    this.boxStatus.BackColor = Color.Purple;
                    break;
            }
        }
    }
}
