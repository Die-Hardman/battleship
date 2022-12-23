using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.src
{
    class Ships
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int[][] Position { get; set; }
        public Alignment Alignment { get; set; }
        public bool Destroyed { get; set; }

        public Ships(string name, int size, Alignment alignment)
        {
            Name = name;
            Size = size;
            Alignment = alignment;
            Position = new int[size][];
            Destroyed = false;
        }
    }
}