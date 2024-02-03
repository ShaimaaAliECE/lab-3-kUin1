using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score {  get; set; }
        public Treasure(int score, string description) : base(description) {
            Score = score;
        }

        public void UpdateTotalScore()
        {
            base.Board.TotalScore += Score;
            Console.WriteLine("Total score is updated to: " + base.Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}
