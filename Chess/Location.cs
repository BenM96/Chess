using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Location
    {
        private char row;
        private int col;
        private string Alphabet = "0ABCDEFGH";
        public char Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.col = value;
            }
        }

        
    }
}
