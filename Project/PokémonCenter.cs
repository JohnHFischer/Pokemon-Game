using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class PokémonCenter
    {
        public int x;
        public int y;
        public Image pokémonCenterImage = Properties.Resources.pokémonCenter;

        public PokémonCenter()
        {
        }

        public PokémonCenter(int _x, int _y, Image _pokémonCenterImage)
        {
            x = _x;
            y = _y;
            pokémonCenterImage = _pokémonCenterImage;
        }
    }
}
