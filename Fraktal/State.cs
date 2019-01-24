using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraktal
{
    [Serializable]
    class State
    {
        public float size;
        public float angle;
        public int x;
        public int y;
        public float dir;

        public State Clone()
        {
            return (State)this.MemberwiseClone();
        }
    }
}
