using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLitePCL;
using UWP_Demo.CS;
using UWP_Demo.Service;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Demo.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserInformation : Page
    {
       
            private IMemberService _memberService;
            private IFileService _fileService;

            public UserInformation()
            {
                this.InitializeComponent();
                this._memberService = new MemberService();
                this._fileService = new LocalFileService();
                this.Loaded += LoadUserInformation;
            }

            private async void LoadUserInformation(object sender, RoutedEventArgs e)
            {
                var memberCredential = await this._fileService.ReadMemberCredentialFromFile();
                if (memberCredential == null)
                {
                    this.Frame.Navigate(typeof(LoginPage));
                }

                if (memberCredential != null)
                {
                    var member = this._memberService.GetInformation(memberCredential.token);
                    Email.Text = member.email;
                    Name.Text = member.firstName + " " + member.lastName;
                }
                LoadDatabase();
            }
        private void LoadDatabase()
        {
            // Get a reference to the SQLite database
            var conn = new SQLiteConnection("sqlitepcldemo.db");
            string sql =
                @"CREATE TABLE IF NOT EXISTS Customer (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),City VARCHAR( 140 ),Contact VARCHAR( 140 ));";
            using (var statement = conn.Prepare(sql))
            {
                statement.Step();
            }

            try
            {
                using (var custstmt = conn.Prepare("INSERT INTO Customer (Name, City, Contact) VALUES (?, ?, ?)"))
                {
                    custstmt.Bind(1, "Hung");
                    custstmt.Bind(2, "Luyen");
                    custstmt.Bind(3, "alo");
                    custstmt.Step();
                }

            }
            catch (Exception)
            {
                // TODO: Handle error
            }



        }
    }
}
