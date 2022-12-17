using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Client_BLCHxVote_WPF.ViewModels
{
    public class InitLogic : BaseClass
    {
        public InitLogic()
        {
            cancellationToken = new CancellationTokenSource();
            token = cancellationToken.Token;
            TimeExtensions();
        }
        private static string _timel;
        private static CancellationToken token;
        private static CancellationTokenSource cancellationToken;
        public static async Task TimeExtensions()
        {
            var t = Service.Client.TimeBlock(new Wpar { });
            await foreach (var response in t.ResponseStream.ReadAllAsync(token))
            {
                _timel = response.EndTime.ToString();
                if (_timel == "Empty")
                {
                    cancellationToken.Cancel();
                    cancellationToken.Dispose();
                    Service.frame.Navigate(new VotingResultView());
                }
                else
                {
                    cancellationToken.Cancel();
                    cancellationToken.Dispose();
                    _timel = "Empty";
                    Service.frame.Navigate(new AuthStartView());
                }
            }
        }
    }
}
