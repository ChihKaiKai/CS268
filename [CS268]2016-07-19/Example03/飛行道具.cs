using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public abstract class 飛行道具 : IFlyBehavior
    {
        public abstract void Fly();
    }
}