using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GADE___1B___Part_1
{
    internal class GameEngine
    {
        //Declare the attributes
        private readonly List<int> currentLvl;//Stores the user's Current level
        private readonly int lvlNumbers;//Stores the number of levels the game consists of
        private readonly int randomValue;//Stores the random value that is within the constants ranges
        public const int MIN_SIZE = 10;
        public const int MAX_SIZE = 20;
        
        //Set a constructor to set the number of levels the game has
        public GameEngine(int gameLvls)
        {
            //Assign the gamelevels to a filed
            lvlNumbers = gameLvls;
            //Create an object for the current level field 
            currentLvl = [];
        }
        //
        public int GenerateValues()
        {
            //Set a number generator that will return a value between the constants
            Random randomValue = new Random();
            return randomValue.Next(MIN_SIZE, MAX_SIZE);//The function will return the constants
        }
        public override string ToString()
        {
            return string.Join(", ",currentLvl);
        }
    }
}
