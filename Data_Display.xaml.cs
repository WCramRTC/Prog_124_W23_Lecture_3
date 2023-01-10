using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using System.Windows.Shapes;
using CsvHelper;

namespace Prog_124_W23_Lecture_3
{
    /// <summary>
    /// Interaction logic for Data_Display.xaml
    /// </summary>
    public partial class Data_Display : Window
    {
        List<IEnumerable<Foo>> records = new List<IEnumerable<Foo>>();
        public Data_Display()
        {
            InitializeComponent();
            LoadData();
            DisplayData();

        } // Data_Display

        public void LoadData()
        {
            using (var reader = new StreamReader("data.csv"))
            {
                using (var csv = new CsvReader(reader,  CultureInfo.InvariantCulture ))
                {
                    records.Add(csv.GetRecords<Foo>());
                }
            }
        }

        public void DisplayData()
        {
            foreach (Foo item in records)
            {
                rtbDisplay.Text = item.Id + " " + item.Name;
            }
        }

    } // class

} // namspace
