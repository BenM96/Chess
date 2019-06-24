using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Piece
    {
        private Location loaction;

        public abstract bool move(Location too);

    }
}
