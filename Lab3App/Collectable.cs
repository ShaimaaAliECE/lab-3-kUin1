using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board {  get; set; }
        
        public Collectable(string name) {
            Description = name;

        }

        public abstract void Display();

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " is collected, Congrats!!!!");
        }
    }
}
