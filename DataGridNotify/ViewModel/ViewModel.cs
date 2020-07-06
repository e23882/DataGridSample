using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo.DataGridNotify.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Declarations
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<DataModel.Data> _DataCollection = new ObservableCollection<DataModel.Data>();
        #endregion

        #region Property
        
        public ObservableCollection<DataModel.Data> DataCollection
        {
            get
            {
                return _DataCollection;
            }
            set
            {
                _DataCollection = value;
            }
        }


        private ObservableCollection<DataModel.CommonData> _ObservableDataCollection = new ObservableCollection<DataModel.CommonData>();
        public ObservableCollection<DataModel.CommonData> ObservableDataCollection
        {
            get
            {
                return _ObservableDataCollection;
            }
            set
            {
                _ObservableDataCollection = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Memberfunction
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                DataCollection.Add(new DataModel.Data
                {
                    ID = i,
                    Price = 10 * i,
                    Qty = 20 * i
                });
                ObservableDataCollection.Add(new DataModel.CommonData()
                {
                    ID = i,
                    Price = 10 * i,
                    Qty = 20 * i
                });
            }
        }
        #endregion
    }
}
