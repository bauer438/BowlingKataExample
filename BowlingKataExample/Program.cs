using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataExample
{
    public class Game
    {
        private int total;

        public Game()
        {
            total = 0;
        }

        public void roll(int pins)
        {
            total += pins;
        }

        public int score()
        {
            return total;
        }

        static void Main(string[] args)
        {
        }
    }
}
