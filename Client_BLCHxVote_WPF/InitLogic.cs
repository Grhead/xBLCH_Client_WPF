using Client_BLCHxVote_WPF.Req;
using Client_BLCHxVote_WPF.Views;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_BLCHxVote_WPF
{
    public class InitLogic
    {
        public InitLogic()
        {
            new Service();
            Service.frame.Navigate(new AuthStartView());
        }
    }
}
