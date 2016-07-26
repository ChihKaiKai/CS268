using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public abstract class Duck
    {
        public string Name { get; set; }

        public IFlyBehavior flybehavior;

        public void Fly()
        {
            if (flybehavior == null)
                this.flybehavior = new 不會飛();
            flybehavior.Fly();
        }
    }
}