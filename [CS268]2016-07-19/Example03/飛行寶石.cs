using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class 飛行寶石 : 飛行道具
    {
        public override void Fly()
        {
            Console.WriteLine("用飛行寶石飛");
        }
    }
}