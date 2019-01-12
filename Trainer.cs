using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Trainer
    {
        public string name;
        public Image[] trainerImage = { Properties.Resources.trainerUp, 
                                   Properties.Resources.trainerDown, 
                                   Properties.Resources.trainerLeft, 
                                   Properties.Resources.trainerRight};
        public int x, y; 
        public int level;
        public string direction;
        public int bounty;

        public Trainer()
        {
        }

        public Trainer(string _name, Image[] _trainerImage, int _x, int _y, int _level, string _direction, int _bounty)
        {
            name = _name;  
            trainerImage = _trainerImage;         
            x = _x;
            y = _y;
            level = _level;
            direction = _direction;
            bounty = _bounty;
        }
    }
}
