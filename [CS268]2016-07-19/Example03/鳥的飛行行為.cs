using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class 鳥的飛行行為 : IFlyBehavior
    {
        public virtual void Fly()
        {
            Console.WriteLine("振翅高飛");
        }
    }
}