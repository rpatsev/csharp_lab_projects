using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();
            var scoreBoard = new ScoreBoard();
            basket.Scored += scoreBoard.AddScore;
            scoreBoard.ScoreAdded += (sender, e) =>
            {
                Console.WriteLine(((ScoreBoard)sender).Score);
            };
            basket.Score();
        }
    }
}
