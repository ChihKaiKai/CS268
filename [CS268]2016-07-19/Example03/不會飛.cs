using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class 不會飛 : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我不會飛");
        }
    }
}