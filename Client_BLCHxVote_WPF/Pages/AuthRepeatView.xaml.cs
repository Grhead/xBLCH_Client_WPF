using Client_BLCHxVote_WPF.ViewModels;
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
    /// Логика взаимодействия для AuthRepeatView.xaml
    /// </summary>
    public partial class AuthRepeatView : Page
    {
        public AuthRepeatView()
        {
            InitializeComponent();
            this.DataContext = new AuthViewModel();
        }

        private void BlockAdress_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }

}