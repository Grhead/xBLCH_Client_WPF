using Client_BLCHxVote_WPF.Views;
using Grpc.Net.Client;
using Newtonsoft.Json;
using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Client_BLCHxVote_WPF.Req
{
    public class Service : BaseClass
    {
        public Service()
        {
            GetTime();
            Task task = ThisTime(EndTimeServer);
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            TimeShow = new TimeSpan(0, 0, 10);
        }    
        public static Frame? frame;
        private static GrpcChannel Channel = GrpcChannel.ForAddress("http://127.0.0.1:7070");
        public static BLCH_Contract.BLCH_ContractClient Client = new BLCH_Contract.BLCH_ContractClient(Channel);
        private CancellationToken token;
        private CancellationTokenSource cancelTokenSource;
        internal static string privk;
        private TimeSpan _timeShow;
        public TimeSpan TimeShow
        {
            get { return _timeShow; }
            set { _timeShow = value; OnPropertyChanged(); }
        }

        private static DateTime TimeFromServer;
        private static TimeSpan EndTimeServer;
        private static void GetTime()
        {
            var block = Service.Client.TimeBlock(new BlockDataGet
            {
                BlockNum = "1"
            });
            var response = JsonConvert.DeserializeObject<FromBlockData>(block.InfoBlock);
            var timeLimit = block.EndTime;
            timeLimit = timeLimit.Replace('h', ':').Replace('m', ':').Replace('s', ' ').TrimEnd();
            //EndTimeServer = new TimeSpan(int.Parse(timeLimit.Split(':')[0]), int.Parse(timeLimit.Split(':')[1]), int.Parse(timeLimit.Split(':')[2]));
            //TimeFromServer = DateTime.Parse(response.TimeStamp) + EndTimeServer;
            TimeFromServer = DateTime.Now + new TimeSpan(int.Parse("0"), int.Parse("0"), int.Parse("30"));
        }
        async public Task ThisTime(TimeSpan timeLimit)
        {
            var temp = new TimeSpan(int.Parse("0"), int.Parse("0"), int.Parse("1"));
            while (token.IsCancellationRequested == false)
            {
                var TShow = (TimeFromServer - DateTime.Now).Duration();
                TimeShow = new TimeSpan(TShow.Days, TShow.Hours, TShow.Minutes, TShow.Seconds); 
                if (TimeShow < temp)
                {
                    cancelTokenSource.Cancel();
                }
                await Task.Delay(100);
            }
            frame.Navigate(new VotingResultView());
            cancelTokenSource.Dispose();
        }
    }
}
