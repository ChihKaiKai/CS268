using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class 鴨子的飛行模式 : 鳥的飛行行為
    {
        public override void Fly()
        {
            base.Fly();
            Console.WriteLine("可是我飛不高");
        }
    }
}