using Client_BLCHxVote_WPF.Req;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Client_BLCHxVote_WPF.Views
{
    public partial class VotingStartView : Page
    {
        public VotingStartView()
        {
            InitializeComponent();
            this.DataContext = new Service();
            foreach (var item in ClientLogical.CandidatesView)
            {
                CandidatesListTier.Items.Add(item.CandidateName);
            }
        }
    }
}
