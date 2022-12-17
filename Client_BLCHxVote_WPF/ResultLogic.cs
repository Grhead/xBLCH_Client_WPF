using Client_BLCHxVote_WPF.Req;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_BLCHxVote_WPF
{
    public class ResultLogic
    {
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
                BalanceView.Add(new CandidateListWithBalance
                {
                    Balance = response.Balance,
                    CandidateName = response.CandidateName,
                    CandidatePK = response.CandidatePK
                });
            }
        }
    }
}
