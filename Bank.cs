using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Bank
    {
        public int x;
        public int y;
        public Image bankImage = Properties.Resources.bankImage;

        public Bank()
        {
        }

        public Bank(int _x, int _y, Image _bankImage)
        {
            x = _x;
            y = _y;
            bankImage = _bankImage;
        }
    }
}
