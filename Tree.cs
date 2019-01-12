using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Tree
    {
        public int x;
        public int y;
    

        public Image treeImage = Properties.Resources.tree;

        public Tree()
        {
        }

        public Tree(int _x, int _y, Image _treeImage)
        {
            x = _x;
            y = _y;        
            treeImage = _treeImage;

        }
    }
}

