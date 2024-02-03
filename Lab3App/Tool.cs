using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        public Tool(string description) : base(description)
        { 

        }

        public virtual void DoAction()
        {
            Console.WriteLine("Tool is used");
        }

        public override abstract void Display();

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }


    }
}
