using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Client_BLCHxVote_WPF.Views
{
    /// <summary>
    /// Логика взаимодействия для VotingResultView.xaml
    /// </summary>
    public partial class VotingResultView : Page
    {
        public VotingResultView()
        {
            InitializeComponent();
            this.DataContext = new ClientLogical();
        }
    }
}
