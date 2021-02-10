using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_08_INotifyPropertyChanged_Interface
{
    public class Suma : System.ComponentModel.INotifyPropertyChanged
    {

        private string num1;
        private string num2;
        private string resultado;

        public string Num1 {
            get { return num1; }
            set {
                int numero;
                bool esNumerico = int.TryParse(value, out numero);
                num1 = esNumerico ? value : "";
                OnPropertyChanged("Num1");
                OnPropertyChanged("Resultado");
            }
        }

        public string Num2
        {
            get { return num2; }
            set
            {
                int numero;
                bool esNumerico = int.TryParse(value, out numero);
                num2 = esNumerico ? value : "";
                OnPropertyChanged("Num2");
                OnPropertyChanged("Resultado");
            }
        }

        public string Resultado
        {
            get { return (int.Parse(num1) + int.Parse(num2)).ToString(); }
            set
            {
                resultado = (int.Parse(num1) + int.Parse(num2)).ToString();
                OnPropertyChanged("Resultado");
            }
        }

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
