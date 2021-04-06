using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace INTEL8086_SYMULATOR
{
    public class Class1 : INotifyPropertyChanged
    {
        private string ax;
        private string bx;
        private string cx;
        private string dx;
       /* public string AX
        {
            get
            {
                return ax;
            }
            set
            {
                int rejestr;
                bool res = int.TryParse(value, out rejestr);
                if (res) ax = value;
                OnPropertyChanged("AX");
            }
        }
        public string BX
        {
            get
            {
                return bx;
            }
            set
            {
                int rejestr;
                bool res = int.TryParse(value, out rejestr);
                if (res) bx = value;
                OnPropertyChanged("BX");
            }
        }
        public string CX
        {
            get
            {
                return cx;
            }
            set
            {
                int rejestr;
                bool res = int.TryParse(value, out rejestr);
                if (res) cx = value;
                OnPropertyChanged("CX");
            }
        }
        public string DX
        {
            get
            {
                return dx;
            }
            set
            {
                int rejestr;
                bool res = int.TryParse(value, out rejestr);
                if (res) dx = value;
                OnPropertyChanged("DX");
            }
        }*/
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
