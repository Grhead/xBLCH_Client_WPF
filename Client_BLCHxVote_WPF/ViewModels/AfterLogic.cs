using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using Grpc.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client_BLCHxVote_WPF.ViewModels
{
    public class AfterLogic
    {
        public AfterLogic() 
        {
            AllChain = new List<string>();
            var request = Service.Client.ChainPrint(new Wpar { });
            for (int i = 0; i < request.InBlock.Count; i++)
            {
                AllChain.Add(request.InBlock[i]);
            }
            cancellationToken = new CancellationTokenSource();
            token = cancellationToken.Token;
        }
        public static List<string>? AllChain { get; set; }
        private static CancellationToken token;
        private static CancellationTokenSource cancellationToken;
        private static string _timel;
        async public Task ThisTime()
        {
            var t = Service.Client.TimeBlock(new Wpar { });
            await foreach (var response in t.ResponseStream.ReadAllAsync())
            {
                _timel = response.EndTime.ToString();
                if (_timel == "Empty")
                {
                    cancellationToken.Cancel();
                    cancellationToken.Dispose();
                    Service.frame.Navigate(new VotingResultView());
                }
            }
        }
    }
}
