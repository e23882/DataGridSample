using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo.DataGridNotify.DataModel
{
    class Data:INotifyPropertyChanged
    {

        private int _Price;
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
                OnPropertyChanged();
            }
        }

        private int _Qty;
        public int Qty
        {
            get
            {
                return _Qty;
            }
            set
            {
                _Qty = value;
                OnPropertyChanged();
            }
        }

        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
                OnPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
