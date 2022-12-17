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
using Client_BLCHxVote_WPF.ViewModels;

namespace Client_BLCHxVote_WPF.Views
{
    /// <summary>
    /// Логика взаимодействия для VotingAfterView.xaml
    /// </summary>
    public partial class VotingAfterView : Page
    {
        private int number = 0;
        public VotingAfterView()
        {
            InitializeComponent();
            this.DataContext = new AfterLogic();
            LabelCreate.Text = AfterLogic.AllChain[number];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            number -= 1;
            if (number >= 0)
            {
                LabelCreate.Text = AfterLogic.AllChain[number];
            } else if (number < 0)
            {
                number= 0;
                LabelCreate.Text = AfterLogic.AllChain[number];
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            number += 1;
            if (number < AfterLogic.AllChain.Count && number >= 0)
            {
                LabelCreate.Text = AfterLogic.AllChain[number];
            } else
            {
                number = AfterLogic.AllChain.Count - 1;
                LabelCreate.Text = AfterLogic.AllChain[number];
            }
        }
    }
}
