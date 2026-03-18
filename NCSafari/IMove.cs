using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    [Obsolete("IMove is deprecated. Please use IFly, ISwim or IHunt instead.")]
    internal interface IMove
    {
        public void Move();
    }
}
