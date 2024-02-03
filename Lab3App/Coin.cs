using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value {  get; set; }

        public Coin(string description, int score, int value) : base(score, description) {
            Value = value;
        }

        public void UpdateTotalValue()
        {
            base.Board.TotalValue += Value;
            Console.WriteLine("Total value is updated to: " + base.Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + base.Description + " is displayed");
        }

    }
}
