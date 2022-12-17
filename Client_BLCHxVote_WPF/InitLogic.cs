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
using System.Threading.Tasks;

namespace Client_BLCHxVote_WPF
{
    public class InitLogic : BaseClass
    {
        public InitLogic()
        {
            TimeExtensions();
        }
        private static string _timel;
        public static async Task TimeExtensions()
        {
            var t = Service.Client.TimeBlock(new Wpar { });
            await foreach (var response in t.ResponseStream.ReadAllAsync())
            {
                _timel = response.EndTime.ToString();
                if (_timel == "Empty")
                {
                    Service.frame.Navigate(new VotingResultView());
                    break;
                }
                else
                {
                    Service.frame.Navigate(new AuthStartView());
                    break;
                }
            }
        }
    }
}
