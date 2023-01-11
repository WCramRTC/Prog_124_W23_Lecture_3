using System;
using System.Collections.Generic;
using System.Configuration;
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
using Microsoft.VisualBasic.FileIO;
using Prog_124_W23_Lecture_3.Class_Examples;

namespace Prog_124_W23_Lecture_3
{
    /// <summary>
    /// Interaction logic for Data_Display.xaml
    /// </summary>
    public partial class Data_Display : Window
    {
        List<Foo> records;
        List<MovieTitle> movies;
        public Data_Display()
        {
            InitializeComponent();
            movies = LoadMovieData();
            DisplayData(movies);

        } // Data_Display

        public List<Foo> LoadData()
        {
            List<Foo> records = new List<Foo>();
            try
            {
                using(TextFieldParser tfp = new TextFieldParser("../../../Data/data.csv"))
                {
                    bool firstLine = true;
                    tfp.TextFieldType = FieldType.Delimited;           
                    tfp.SetDelimiters(",");

                    while(!tfp.EndOfData)
                    {                  
                        string[] data = tfp.ReadFields();

                        if (firstLine)
                        {
                            firstLine = false;
                            continue;
                        }

                        records.Add(new Foo
                        {
                            Id = int.Parse(data[0]),
                            Name = data[1]
                        });

                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return records;
        } // LoadData

        public List<MovieTitle> LoadMovieData()
        {
            List<MovieTitle> records = new List<MovieTitle>();
            try
            {
                using (TextFieldParser tfp = new TextFieldParser("../../../Data/imdb.csv"))
                {
                    bool firstLine = true;
                    tfp.TextFieldType = FieldType.Delimited;
                    tfp.SetDelimiters(",");

                    while (!tfp.EndOfData)
                    {
                        string[] data = tfp.ReadFields();

                        if (firstLine)
                        {
                            firstLine = false;
                            continue;
                        }

                        records.Add(new MovieTitle
                        {
                            Rank = data[0],
                            Name = data[1],
                            Year = data[2],
                            Certificate = data[3],
                            Runtime = data[4],
                            Genre = data[5],
                            Metascore = data[6],
                            Gross = data[7],
                            Rating = data[8]
                            // Rank Name Year Cert Runtime Genre Meta Gross Rating
                        });


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return records;
        } // LoadData

        public void DisplayData(List<Foo> records)
        {
            rtbDisplay.Text = "";
            foreach (Foo item in records)
            {
                rtbDisplay.Text += item.Id + " " + item.Name + "\n";
            }
        }

        public void DisplayData(List<MovieTitle> records)
        {
            rtbDisplay.Text = "";
            foreach (MovieTitle item in records)
            {
                rtbDisplay.Text += item.ToString() + "\n";
            }
        }

    } // class

} // namspace
