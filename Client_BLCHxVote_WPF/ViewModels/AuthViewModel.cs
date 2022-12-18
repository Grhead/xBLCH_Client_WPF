using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Diagnostics;

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
            if (PassText == null && PublicKText == null && SaltText == null)
            {
                MessageBox.Show("Поля пусты");
            }
            else if (PassText == null)
            {
                MessageBox.Show("Ошибка ввода паспортных данных");
            } else if (PublicKText == null)
            {
                MessageBox.Show("Ошибка ввода Адреса");
            } else if (SaltText == null)
            {
                MessageBox.Show("Ошибка ввода кода");
            }
            else
            {
                var reply = Service.Client.AuthRegister(new RegData
                {
                    Passport = PassText,
                    PublicK = PublicKText,
                    Salt = SaltText
                });
                if (reply.Distortion == "pass" || reply.Distortion == "pk")
                {
                    MessageBox.Show("Error");
                    PublicKText = null;
                    PassText = null;
                    SaltText = null;
                }
                else if (reply.Distortion == "time")
                {
                    Service.frame.Navigate(new VotingResultView());
                }
                else if (reply.Distortion == "cdt")
                {
                    MessageBox.Show("Использован адрес кандидата");
                    PublicKText = null;
                    PassText = null;
                    SaltText = null;
                }
                else
                {
                    Service.privk = PrivateKText;
                    MessageBox.Show(reply.Distortion);
                    Service.frame.Navigate(new VotingStartView());

                }
            }
            
        });
        public RelayCommand StartCommand => _startCommand ??= new RelayCommand(x =>
        {
            if (PublicKText == null && PrivateKText == null)
            {
                MessageBox.Show("Поля пусты");
            }
            else if (PublicKText == null)
            {
                MessageBox.Show("Ошибка ввода Адреса");
            }
            else if (PrivateKText == null)
            {
                MessageBox.Show("Ошибка ввода приватного ключа");
            }
            else
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
                    PublicKText = null;
                    PrivateKText = null;
                    MessageBox.Show("Error");
                }
                else if (reply.Distortion == "zero")
                {
                    Service.frame.Navigate(new VotingAfterView());
                }
                else
                {
                    Service.frame.Navigate(new VotingResultView());
                }
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
