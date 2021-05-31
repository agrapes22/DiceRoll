using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Dice
    {
        private int sides;
        Random r = new Random();
        Random r2 = new Random(DateTime.Now.Millisecond + 998); //offsetting seed value to create different numbers
        int time = 1;

        public Dice(int sides)
        {
            this.sides = sides;
        }

        //roll dice
        public int rollDie()
        {
            //alternate between the two random objects to avoid double numbers
            if (time == 1)
            {
                r.Next(1, sides + 1); //"refresh" the random number
                int val = r.Next(1, sides + 1);
                time++;
                return val;
                
            }
            //use second random object
            else
            {
                r2.Next(1, sides + 1); //"refresh" the random number
                int val = r2.Next(1, sides + 1);
                time = time - 1;
                return val;
                
            }
        }

    }
}
