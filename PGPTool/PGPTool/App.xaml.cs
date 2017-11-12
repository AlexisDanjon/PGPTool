using PGPTool.Data;
using PGPTool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PGPTool
{
	public partial class App : Application
	{
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        static RestService resetService;

        public App ()
		{
			InitializeComponent();

			MainPage = new LoginPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        internal static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }

        internal static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }

        internal static RestService RestService
        {
            get
            {
                if (resetService == null)
                {
                    resetService = new RestService();
                }
                return resetService;
            }
        }
    }
}
