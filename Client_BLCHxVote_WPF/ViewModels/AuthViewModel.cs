using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client_BLCHxVote_WPF.ViewModels
{
    public class AuthViewModel
    {
        private RelayCommand? _enterCommand;
        public RelayCommand EnterCommand => _enterCommand ??= new RelayCommand(x =>
        {
            Service.frame.Navigate(new AuthRepeatView());
        });
        public RelayCommand CreateCommand => _createCommand ??= new RelayCommand(x =>
        {
            var reply = Service.Client.AuthRegister(new RegData
            {
                Passport = PassText,
                PublicK = PublicKText,
                Salt = SaltText
            });
            if (reply.Distortion == "1")
            {
                Service.privk = PrivateKText;
                Service.frame.Navigate(new VotingStartView());
            }
            else if (reply.Distortion == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show(reply.Distortion);
                Service.frame.Navigate(new VotingResultView());
            }
        });
        public RelayCommand StartCommand => _startCommand ??= new RelayCommand(x =>
        {
            var reply = Service.Client.AuthLogin(new AuthData
            {
                PrivateK = PrivateKText,
                PublicK = PublicKText
            });
            if (reply.Distortion == "1")
            {
                Service.privk = PrivateKText;
                Service.frame.Navigate(new VotingStartView());
            }
            else if (reply.Distortion == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                Service.frame.Navigate(new VotingResultView());
            }
        });
        public string PassText { get; set; }
        public string PublicKText { get; set; }
        public string SaltText { get; set; }
        public string PrivateKText { get; set; }
        private RelayCommand? _createCommand;
        private RelayCommand? _startCommand;
    }
}
