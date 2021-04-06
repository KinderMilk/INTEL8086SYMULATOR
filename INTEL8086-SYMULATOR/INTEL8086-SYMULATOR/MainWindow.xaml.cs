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
using System.ComponentModel;

namespace INTEL8086_SYMULATOR
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public  partial class MainWindow : Window
    {
        
        public Class1 rejestry { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            rejestry = new Class1 { AX = "00000", BX = "00000" };
            this.DataContext = rejestry;
            
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

            AX_TXB.Text = BX_TXB.Text;
        }

        private void AXCX_Click(object sender, RoutedEventArgs e)
        {
            AX_TXB.Text = CX_TXB.Text;
        }

        private void AXDX_Click(object sender, RoutedEventArgs e)
        {
            AX_TXB.Text = DX_TXB.Text;
        }

        private void BXAX_Click(object sender, RoutedEventArgs e)
        {
            BX_TXB.Text = AX_TXB.Text;
        }

        private void BXCX_Click(object sender, RoutedEventArgs e)
        {
            BX_TXB.Text = CX_TXB.Text;
        }

        private void BXDX_Click(object sender, RoutedEventArgs e)
        {
            BX_TXB.Text = DX_TXB.Text;
        }

        private void CXAX_Click(object sender, RoutedEventArgs e)
        {
            CX_TXB.Text = AX_TXB.Text;
        }

        private void CXBX_Click(object sender, RoutedEventArgs e)
        {
            CX_TXB.Text = BX_TXB.Text;
        }

        private void CXDX_Click(object sender, RoutedEventArgs e)
        {
            CX_TXB.Text = DX_TXB.Text;
        }

        private void DXAX_Click(object sender, RoutedEventArgs e)
        {
            DX_TXB.Text = AX_TXB.Text;
        }

        private void DXBX_Click(object sender, RoutedEventArgs e)
        {
            DX_TXB.Text = BX_TXB.Text;
        }

        private void DXCX_Click(object sender, RoutedEventArgs e)
        {
            DX_TXB.Text = CX_TXB.Text;
        }

       
    }
}
