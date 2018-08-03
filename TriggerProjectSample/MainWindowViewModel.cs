using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
namespace TriggerProjectSample
{
    public class MainWindowViewModel
    {
        private ICommand _leftButtonDownCommand;

        private ICommand _button2;

        public ICommand LeftMouseButtonDown
        {
            get
            {
                return _leftButtonDownCommand ?? (_leftButtonDownCommand = new RelayCommand(
                   x =>
                   {
                       DoStuff();
                   }));
            }
        }

        public ICommand Button2
        {
            get
            {
                return _button2 ?? (_button2 = new RelayCommand(
                   x =>
                   {
                      button2();
                   }));
            }
        }


        private static void DoStuff()
        {
            MessageBox.Show("Responding to left mouse button click event...");
        }

        private static void button2()
        {
            MessageBox.Show("You clicked button2");
        }

        //private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        //{
        //    Storyboard sb = Resources[Storyboard] as Storyboard;
        //    sb.Begin(pnl);

        //    if (Storyboard.Contains("Show"))
        //    {
        //        btnHide.Visibility = System.Windows.Visibility.Visible;
        //        btnShow.Visibility = System.Windows.Visibility.Hidden;
        //    }
        //    else if (Storyboard.Contains("Hide"))
        //    {
        //        btnHide.Visibility = System.Windows.Visibility.Hidden;
        //        btnShow.Visibility = System.Windows.Visibility.Visible;
        //    }
        //}
    }
}
