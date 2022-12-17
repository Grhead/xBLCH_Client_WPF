using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Grpc.Core;
using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Threading;

namespace Client_BLCHxVote_WPF.ViewModels
{
    public class ClientLogical : BaseClass
    {
        public ClientLogical()
        {
            cancellationToken = new CancellationTokenSource();
            token = cancellationToken.Token;
            Task task = ThisTime();
            GetCandidates();
        }
        private static string _timel;
        private static CancellationToken token;
        private static CancellationTokenSource cancellationToken;
        private string _timeShow;
        public string TimeShow
        {
            get { return _timeShow; }
            set { _timeShow = value; OnPropertyChanged(); }
        }
        async public Task ThisTime()
        {
            var t = Service.Client.TimeBlock(new Wpar { });
            await foreach (var response in t.ResponseStream.ReadAllAsync())
            {
                TimeShow = response.EndTime.ToString();
                if (TimeShow == "Empty")
                {
                    cancellationToken.Cancel();
                    cancellationToken.Dispose();
                    Service.frame.Navigate(new VotingResultView());
                }
            }
        }
        private RelayCommand? _voteCommand;
        private CandidateList? _selectedItem;
        public CandidateList SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; }
        }
        private static List<CandidateList> _candidatesView;
        public static List<CandidateList> CandidatesView
        {
            get { return _candidatesView; }
            set { _candidatesView = value; }
        }
        public RelayCommand VoteCommand => _voteCommand ??= new RelayCommand(x =>
        {
            CandidateList sel = new() { CandidatePK = "0", CandidateName = "0" };
            IsComplited bos = new IsComplited { Ic = false };
            if (SelectedItem != null)
            {
                sel = SelectedItem;
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
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        });
        public static async void GetCandidates()
        {
            CandidatesView = new List<CandidateList>();
            var cv = Service.Client.ViewCandidates(new Wpar { });
            await foreach (var response in cv.ResponseStream.ReadAllAsync())
            {
                CandidatesView.Add(new CandidateList { CandidateName = response.CandidateName, CandidatePK = response.CandidatePK});
            }
        }
    }
}
