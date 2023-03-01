using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace RAA2_Module_3_Skills
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MyForm2 : Window
    {
        ObservableCollection<SpatialElement> dataList { get; set; }
        ObservableCollection<string> dataItems { get; set; }
        public MyForm2(List<SpatialElement> _dataList)
        {
            InitializeComponent();

            dataList = new ObservableCollection<SpatialElement>(_dataList);
            
            dataItems = new ObservableCollection<string> { "one", "two", "three", "four" };
            grdData.ItemsSource = dataList;
            Item4Col.ItemsSource = dataItems;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        public List<SpatialElement> GetData()
        {
            List<SpatialElement> returnList = new List<SpatialElement>();

            foreach(SpatialElement item in grdData.SelectedItems) 
            {
                returnList.Add(item);
            }

            return returnList; 
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    foreach (DataClass2 curRow in dataList)
            //    {
            //        if (grdData.SelectedItem == curRow)
            //            dataList.Remove(curRow);
            //    }
            //}
            //catch (Exception)
            //{}
            
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //dataList.Add(new DataClass2("", "", false, ""));
        }
    }

    public class DataClass2
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public bool Item3 { get; set; }
        public string Item4 { get; set; }

        public DataClass2(string item1, string item2, bool item3, string item4)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }
    }
        

}
