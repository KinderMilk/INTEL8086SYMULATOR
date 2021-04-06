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

namespace INTEL8086_SYMULATOR
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ax;
        public int bx;
        public int cx;
        public int dx;
        public int AX 
        {
            get 
            {
                return this.ax;
            }
            set 
            {
                this.ax = value;
            }
        }
        public int BX
        {
            get
            {
                return this.bx;
            }
            set
            {
                this.bx = value;
            }
        }
        public int CX
        {
            get
            {
                return this.cx;
            }
            set
            {
                this.cx = value;
            }
        }
        public int DX
        {
            get
            {
                return this.dx;
            }
            set
            {
                this.dx = value;
            }
        }
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void AXBX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AXCX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AXDX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BXAX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BXCX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BXDX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CXAX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CXBX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CXDX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DXAX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DXBX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DXCX_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
