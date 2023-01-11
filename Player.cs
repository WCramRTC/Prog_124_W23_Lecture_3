using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_3
{
    // Access Modifier
    // internal public protected private
    
    public class Player
    {
        // 4 Main Members of an Class

        // Fields
        // WHat is a field
        // Fields are variables that are related to our class
        // By default, anything with out an access modifier is private

        // Default value for string is what?
        // ""
        public string FirstName;
        public string LastName;
        public string PlayerNumber;
        public string Team;

        // Default value of short
        // 0
        public short AtBat;
        public short Hits;
        public short HomeRuns;
        // at bat
           

        // CSV - Comma Seperated Values
        // .csv

        // Will,
        // Cram,
        // 7,
        // San Francisco Giants


        // Constructor
        // Access Modifer - SAME NAME AS THE CLASS - No Return Type - Can Have Parameters
        // Any class has a DEFAULT Constructor
        // Constructors allow us to restrict what information is needed on creating a new instance

        // Default Constructor - Takes no arguments
        // ONce youve created a constructor, it gets rid of the default constructor

        // Constructor that takes ALL fields
        // Player ( string string string string shot short shot )
        public Player(
            string FName, 
            string LName, 
            string PlayerNumber, 
            string TeamName, 
            short atBat, 
            short hits, 
            short homeruns)
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.PlayerNumber = PlayerNumber;
            this.Team = TeamName;
            this.AtBat = atBat;
            this.Hits = hits;
            this.HomeRuns = homeruns;
        } // Player

        // Overload our Constructor
        // Create another constructor that has DIFFERENT PAREMETERS

        // Method Signature is different
        // Combination of 2 Things ( NAME and TYPES and ORDER of PARAMETERS PASSED IN )
        // Player ( string )
        public Player(string FirstName, string LastName, string PlayerNumber, string Team)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PlayerNumber = PlayerNumber;
            this.Team = Team;
        }
        // Player () 

        // Properties



        // Methods


    } // Comment end of Player Class

} // end of Namespace
