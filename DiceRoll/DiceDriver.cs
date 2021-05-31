using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class DiceDriver
    {
        //hold number of sides
        int sides;

        //hold each face value
        int face1;
        int face2;

        //create 2 dice
        Dice dice1;
        Dice dice2;

        //create diceDriver and both dice with sides specified
        public DiceDriver(int sides)
        {
            this.sides = sides;

            //set dice to specified sides
            dice1 = new Dice(sides);
            dice2 = new Dice(sides);
        }

        //roll until there is 2 1's
        public Boolean drive()
        {
            //roll both dice
            face1 = dice1.rollDie();
            face2 = dice2.rollDie();

            //check if both values are 1
            if (face1 == 1 && face2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return false;
        }

        //return face values
        public int getFace1()
        {
            return face1;
        }

        //return face values
        public int getFace2()
        {
            return face2;
        }

    }
}
