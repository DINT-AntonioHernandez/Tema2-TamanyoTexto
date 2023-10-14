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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton rd= (RadioButton)sender;
            if(rd.Tag.ToString()=="grande")
            {
                salidaTxt.FontSize = "25";
            }
            else if(rd.Tag.ToString()=="mediano")
            {
                salidaTxt.FontSize = "19";
            }
            else
            {
                salidaTxt.FontSize = "16";
            }
        }
    }
}
