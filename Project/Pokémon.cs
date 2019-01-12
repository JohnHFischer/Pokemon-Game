using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Pokémon
    {
        public string name;
        public string description;
        public Image[] pokémonImage = { Properties.Resources.pikachuImage, 
                                   Properties.Resources.squeedleImage, 
                                   Properties.Resources.geodudeImage,
                                   Properties.Resources.pidgeyImage,
                                   Properties.Resources.caterpieImage,
                               Properties.Resources.sudowoodoImage};

        public Image[] pokémonImageBack = { Properties.Resources.pikachuBack, 
                                   Properties.Resources.squeedleBack, 
                                   Properties.Resources.geodudeBack,
                                   Properties.Resources.pidgeyBack,
                                   Properties.Resources.caterpieBack,
                                   Properties.Resources.sudowoodoBack};
        public int x, y;
        public int imageNumber;
        public string ability1;
        public string ability2;
        public string ability3;
        public string ability4;
        public int baseHp;
        public int hpPerLevl;
        public int health;
        public int maxHealth;
        public int xp;
        public int level;
        public Boolean poisoned;
        public int catchResistance;
        public Boolean fainted;
   

        public Pokémon()
        {
        }

        public Pokémon(string _name, string _description, Image[] _pokémonImage, Image[] _pokémonImageBack, int _imageNumber, int _x, int _y, string _ability1, string _ability2, string _ability3, string _ability4, int _health, int _maxHealth, int _baseHp, int _hpPerLevel, int _xp, int _level, Boolean _poisoned, int _catchResistance, Boolean _fainted)
        {
            name = _name;
            description = _description;
            pokémonImage = _pokémonImage;
            pokémonImageBack = _pokémonImageBack;
            imageNumber = _imageNumber;
            x = _x;
            y = _y;
            ability1 = _ability1;
            ability2 = _ability2;
            ability3 = _ability3;
            ability4 = _ability4;
            baseHp = _baseHp;
            hpPerLevl = _hpPerLevel;
            health = _health;
            maxHealth = _maxHealth;
            xp = _xp;            
            level = _level;
            poisoned = _poisoned;
            catchResistance = _catchResistance;
            fainted = _fainted;
        }
    }
}
