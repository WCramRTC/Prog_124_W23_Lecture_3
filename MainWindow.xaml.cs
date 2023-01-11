using System;
using System.Collections.Generic;
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


namespace Prog_124_W23_Lecture_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BankAccount will = new BankAccount("Will", 20000000);
            rtbDisplay.Text = will.Name + "\n";
            // value = "Zack"
            //will.Name = "Zack";
            //rtbDisplay.Text = will.Name;
            rtbDisplay.Text = will.Balance.ToString() + "\n";

            //will.Balance = -500;
            rtbDisplay.Text += will.Balance.ToString();

            //rtbDisplay.Text = $"{will.Name} - {will.Balance.ToString("c")}";

            //will.Balance = -500;

            //rtbDisplay.Text += $"\n{will.Name} - {will.Balance.ToString("c")}";

        } // 

        // Create a helper method
        public string FormatPlayer(Player player)
        {
            string display = $"" +
                $"Name - {player.FirstName} {player.LastName}\n" +
                $"AtBat - {player.AtBat}\n" +
                $"HomeRuns - {player.HomeRuns}";

            return display;
        } // FormatPlayer

        public void FieldsExample()
        {

            //// Created an instance of an empty player object
            //Player player = new Player();
            //player.FirstName = "Bander";
            //player.LastName = "Saleh";
            //player.AtBat = 300;
            //player.HomeRuns = 299;
            //// Stack - player = 3075 - An Address on the Heap
            //// Heap - new Player - 3075

            //// WHen in doubt, use a dot
            //rtbDisplay.Text = FormatPlayer(player);

            //Player brewers = new Player()
            //{
            //    FirstName = "Zach",
            //    LastName = "Zepezauer",
            //    AtBat = 200,
            //    HomeRuns = 199,
            //    Team = "Brewers"
            //};

            //Player giants = new Player();

            //rtbDisplay.Text += "\n" + FormatPlayer(giants);
        } // FieldsExample

        public void OverloadConstructorExample()
        {
            //Player player = new Player();
            //player.FirstName = "Bander";
            //player.LastName = "Saleh";
            //player.AtBat = 300;
            //player.HomeRuns = 299;

            //Player mariners = new Player("Bander", "Saleh", "10", "Seattle Mariners", 300, 300, 299);

            //rtbDisplay.Text = FormatPlayer(mariners);

            //Player brewers = new Player("Zack", "Zepezauer", "6", "Brewers");

            //rtbDisplay.Text += FormatPlayer(brewers);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Data_Display().Show();
  
        }

        // Primitive Data Types
        // basic immuteable data types
        // int
        // double
        // bool
        // char

        // Variable names and primitive VALUES are stored on stack
    }
}
