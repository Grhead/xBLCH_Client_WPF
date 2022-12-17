using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using Grpc.Net.Client;
using Client_BLCHxVote_WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Media.Media3D;
using System.Windows.Controls;
using Google.Protobuf;
using System.Threading;
using Grpc.Core;
using System.Reflection.PortableExecutable;
using Newtonsoft.Json;
using System.Globalization;
using System.Timers;
using System.Windows.Documents;
using Google.Protobuf.WellKnownTypes;
using System.Windows.Media.Animation;

namespace Client_BLCHxVote_WPF
{
    public class ClientLogical : BaseClass
    {
        public ClientLogical()
        {
            AllChain = new List<string>();
            var request = Service.Client.ChainPrint(new Wpar { });
            Console.WriteLine(request.InBlock);
            for (int i = 0; i < request.InBlock.Count; i++)
            {
                AllChain.Add(request.InBlock[i]);
            }
        }
        private RelayCommand? _createCommand;
        private RelayCommand? _startCommand;
        private RelayCommand? _enterCommand;
        private RelayCommand? _voteCommand;
        private string? _selectedItem;
        public string SelectedItem 
        { 
            get { return _selectedItem; } 
            set { _selectedItem = value; } 
        }
        public static List<string>? AllChain { get; set; }
        public string PassText { get; set; }
        public string PublicKText { get; set; }
        public string SaltText { get; set; }
        public string PrivateKText { get; set; }
        private static List<CandidateList> _candidatesView;
        public static List<CandidateList> CandidatesView
        {
            get { return _candidatesView; }
            set { _candidatesView = value; }
        }
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
                GetCandidates();
                Service.frame.Navigate(new VotingStartView());
            }
            else if (reply.Distortion == "0")
            {
                MessageBox.Show("Error");
            } else
            {
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
                GetCandidates();
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
        public RelayCommand VoteCommand => _voteCommand ??= new RelayCommand(x =>
        {
            CandidateList sel = new CandidateList { CandidatePK = "0", CandidateName = "0" };
            IsComplited bos = new IsComplited { Ic = false };
            if (SelectedItem != null)
            {
                sel = CandidatesView.First(x => x.CandidateName == SelectedItem);
            }
        if (sel.CandidateName != "0" || sel.CandidatePK != "0")
            {
                bos = Service.Client.Vote(new LowData
                {
                    UserCandidate = sel.CandidatePK,
                    Private = Service.privk,
                    Num = 1
                });
                if (bos.Ic == true)
                {
                    Service.frame.Navigate(new VotingAfterView());
                } else
                {
                    MessageBox.Show("Error");
                }
            }
        });
        public RelayCommand EnterCommand => _enterCommand ??= new RelayCommand(x =>
        {
            Service.frame.Navigate(new AuthRepeatView());
        });
        public static async void GetCandidates()
        {
            CandidatesView = new List<CandidateList>();
            var cv = Service.Client.ViewCandidates(new Wpar { });
            await foreach (var response in cv.ResponseStream.ReadAllAsync())
            {
                CandidatesView.Add(response);
            }
        }
        private string _soloWinner;
        public string SoloWinner
        {
            get
            {
                return _soloWinner;
            }
            set
            {
                _soloWinner = value;
                OnPropertyChanged();
            }
        }
        private static List<CandidateListWithBalance> _balanceView;
        public static List<CandidateListWithBalance> BalanceView
        {
            get { return _balanceView; }
            set { _balanceView = value; }
        }
        public async void GetProcent()
        {
            var cw = Service.Client.ResultsWinner(new Wpar { });
            await foreach (var response in cw.ResponseStream.ReadAllAsync())
            {
                BalanceView.Add(response);
            }
            SoloWinner = GetProcentName();
        }
        private static string GetProcentName()
        {
            var solowinner = Service.Client.SoloWinner(new Wpar { });
            return solowinner.CandidateName;
        }
        private string _timel;
        public string Timel
        {
            get { return _timel; }
            set { _timel = value; OnPropertyChanged(); }
        }
        public static async void TimeExtensions()
        {
            var classForTime = new ClientLogical();
            var t = Service.Client.TimeBlock(new Wpar { });
            await foreach (var response in t.ResponseStream.ReadAllAsync())
            {
                classForTime.Timel = response.EndTime.ToString();
            }
        }
    }
}
