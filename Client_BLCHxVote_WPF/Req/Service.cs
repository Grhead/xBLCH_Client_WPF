using Client_BLCHxVote_WPF.Views;
using Google.Protobuf.Reflection;
using Grpc.Net.Client;
using Newtonsoft.Json;
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
        public static Frame? frame;
        private static GrpcChannel Channel = GrpcChannel.ForAddress("http://127.0.0.1:7070");
        public static BLCH_Contract.BLCH_ContractClient Client = new BLCH_Contract.BLCH_ContractClient(Channel);
        internal static string privk;
    }
}
