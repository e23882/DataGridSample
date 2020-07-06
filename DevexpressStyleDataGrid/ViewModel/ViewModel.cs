using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo.DevexpressStyleDataGrid.ViewModel
{
    class ViewModel
    {
        #region Declarations
        private ObservableCollection<DataGridDemo.DevexpressStyleDataGrid.DataModel.DataModel> _DataCollection = new ObservableCollection<DataGridDemo.DevexpressStyleDataGrid.DataModel.DataModel>();
        #endregion

        #region Property
        public ObservableCollection<DataGridDemo.DevexpressStyleDataGrid.DataModel.DataModel> DataCollection
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
        #endregion

        #region Memberfunction
        public ViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                DataCollection.Add(new DataGridDemo.DevexpressStyleDataGrid.DataModel.DataModel()
                {
                    ID = i,
                    Name = "User" + i
                });
            }
        }
        #endregion
    }
}
