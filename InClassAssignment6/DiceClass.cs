using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment6
{
    class DiceClass
    {
        //  Create the properties
        private int dieSides = 6;

        //  Create a constructor for the DiceClass class.
        public DiceClass(int number, int numDiceSides)
        {
            //  Initialize the value for dieSides
            dieSides = numDiceSides;
        }

        /// <summary>
        /// Method to Role the Dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        public int roleDie()
        {
            Random newRandomNumber = new Random();
            //  Rolling the dice is creating a random num b/w 1 and the num of sides on the dice 
            int randomNumber = newRandomNumber.Next(1, dieSides);
            return randomNumber;
            //  Could also do like this:
            //  return newRandomNumber.Next(1, dieSides);
        }
    }
}
