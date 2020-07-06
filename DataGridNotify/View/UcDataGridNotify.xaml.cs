using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DataGridDemo.DataGridNotify
{
    /// <summary>
    /// UcDataGridNotify.xaml 的互動邏輯
    /// </summary>
    public partial class UcDataGridNotify : UserControl
    {
        DataGridNotify.ViewModel.ViewModel main;
        public UcDataGridNotify()
        {
            InitializeComponent();
            main = new DataGridNotify.ViewModel.ViewModel();
            this.DataContext = main;
            AutoUpdateData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //main.DataCollection.RemoveAt(0);
            //main.DataCollection.Add(new DataModel.Data()
            //{
            //    ID = 999,
            //    Qty = 999,
            //    Price = 999
            //});
        }

        public void Update()
        {
            while (true)
            {
                var DataCount = main.DataCollection.Count;
                Random rd = new Random();
                var RandomNumber = rd.Next(1, DataCount);

                switch (RandomNumber % 2)
                {
                    case 0:
                        main.DataCollection[RandomNumber].Qty = main.DataCollection[RandomNumber].Qty - 1;
                        break;
                    default:
                        main.DataCollection[RandomNumber - 1].Price = main.DataCollection[RandomNumber - 1].Price - 1;
                        break;
                }
                Thread.Sleep(1000);
            }
            
        }

        public void AutoUpdateData()
        {
            Thread th = new Thread(Update);
            th.Start();
        }
    }
}
