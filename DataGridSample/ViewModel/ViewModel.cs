using System.Collections.ObjectModel;

namespace DataGridDemo.DataGridSample.ViewModel
{
    class ViewModel
    {
        #region Declarations
        private ObservableCollection<DataModel> _DataCollection = new ObservableCollection<DataModel>();
        #endregion

        #region Property
        public ObservableCollection<DataModel> DataCollection
        {
            get
            {
                return _DataCollection;
            }
        }
        #endregion

        #region Memberfunction
        public ViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                DataCollection.Add(new DataModel()
                {
                    ID = i,
                    Name = "User" + i
                });
            }
        }
        #endregion
    }
}
