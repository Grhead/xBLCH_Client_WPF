using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Client_BLCHxVote_WPF.ViewModels
{
    public class ResultLogic : BaseClass
    {
        public ResultLogic()
        {
            GetProcent();
            SoloWinner = GetProcentName();
        }
        private string _soloWinner;
        public string SoloWinner
        {
            get { return _soloWinner; }
            set { _soloWinner = value; OnPropertyChanged(); }
        }
        private static List<CandidateListWithBalance> _balanceView;
        public static List<CandidateListWithBalance> BalanceView
        {
            get { return _balanceView; }
            set { _balanceView = value; }
        }
        public static async void GetProcent()
        {
            BalanceView = new List<CandidateListWithBalance>();
            var cw = Service.Client.ResultsWinner(new Wpar { });
            await foreach (var response in cw.ResponseStream.ReadAllAsync())
            {
                BalanceView.Add(response);
            }
            BalanceView = BalanceView.OrderByDescending(x => x.Balance).ToList();
        }
        private static string GetProcentName()
        {
            var solowinner = Service.Client.SoloWinner(new Wpar { });
            if (solowinner.CandidatePK == "0")
            {
                return "Перевыборы запланированы";
            }
            return solowinner.CandidateName;
        }
    }
}