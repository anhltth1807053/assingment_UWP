using System;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using Windows.Storage;
using UWP_Demo.CS;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using UWP_Demo.Service;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Demo.View
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;

        public LoginPage()
        {
            Debug.WriteLine("Init login.");
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }


        private void Do_Login(object sender, RoutedEventArgs e)
        {
            try
            {
                var memberLogin = new MemberLogin
                {
                    email = this.Email.Text,
                    password = this.Password.Password
                };

                var memberCredential = this._memberService.Login(memberLogin);
                ProjectConfiguration.CurrentMemberCredential = memberCredential;
                this._fileService.SaveMemberCredentialToFile(memberCredential);
                this.Frame.Navigate(typeof(View.SongService.AllSong1));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnOrRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Frame.Navigate(typeof(RegisterPage));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
