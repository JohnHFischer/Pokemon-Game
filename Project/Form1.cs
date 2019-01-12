using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Project
{
    public partial class Form1 : Form
    {
        int tackleDamage = 6;
        int tackleScaling = 2;

        int poisonstrikeDamage = 4;
        int poisonstrikeScaling = 1;

        //uses hp scaling**
        int bodyslamDamage = 3;        

        int gustDamage = 2;
        int gustScaling = 3;

        int bugbiteDamage = 15;
        int bugbiteScaling = 2;

        int rockthrowDamage = 6;
        int rockthrowScaling = 2;

        int flailDamage = 8;
        int flailScaling = 4;

        int lowkickDamage = 5;
        int lowkickScaling = 6;

        int thundershockDamage = 5;
        int thundershockScaling = 6;

        int stingDamage = 5;
        int stingScaling = 6;

        int scratchDamage = 5;
        int scratchScaling = 6;

        int pikachuBaseHp = 20;
        int pikachuHpPerLevel = 8;
        string pikachuDescription = "Lightning pokémon";

        int geodudeBaseHp = 30;
        int geodudeHpPerLevel = 11;
        string geodudeDescription = "Rock hard tough pokémon";

        int squeedleBaseHp = 19;
        int squeedleHpPerLevel = 8;
        string squeedleDescription = "Catterpiller pokémon";

        int pidgeyBaseHp = 20;
        int pidgeyHpPerLevel = 9;
        string pidgeyDescription = "Bird Pokémon";

        int caterpieBaseHp = 20;
        int caterpieHpPerLevel = 9;
        string caterpieDescription = "Caterpie Pokémon";

        int sudowoodoBaseHp = 80;
        int sudowoodoHpPerLevel = 10;
        string sudowoodoDescription = "Tree Pokémon";

        int spinarakBaseHp;
        int spinarakHpPerLevel;
        string spinarakDescription;

        int hoothootBaseHp;
        int hoothootHpPerLevel;
        string hoothootDescription;

        int healthPotHeal = 20;

        Boolean catchingPokémon = false;
        int catchStrenth;
        int catchResistance;
        int catchCounter;
        int catchX = 425;

        int bounty;

        Boolean aKeyDown, dKeyDown, wKeyDown, sKeyDown, spaceKeyDown, escKeyDown, tabKeyDown = false;
        string direction = "null";
        string drawDirection = "null";
        int mouseX, mouseY;
        int directionTicks = 10;
        int drawTicks;
        string upInteraction = "null";
        string downInteraction = "null";
        string leftInteraction = "null";
        string rightInteraction = "null";

        string currentScreen = "game";

        string playerName = "Ash";
        int cash = 10000;

        Random randNum = new Random();

        int randomNumber;

        Boolean upBlocked;
        Boolean downBlocked;
        Boolean leftBlocked;
        Boolean rightBlocked;

        Boolean inGrass = false;
        Boolean inGameMenu = false;
        Boolean inGameyn = false;

        Boolean inFight = false;
        Boolean inGym = false;
        int gymNumber;

        Boolean running = false;
        Boolean fightItem = false;
        string itemUsing;
        int runningCounter;

        Boolean purchaseComplete = false;

        Boolean msgShowing;
        int msgCounter;
        string msg;
        int signNumber;
        int trainerNumber;
        string menuSelected = "items";
        string ynSelected = "no";
        string fightSelected = "fight";
        string attackSelected = "null";

        Boolean playerTurn = true;
        string enemyUsed = "null";
        int enemyHpPercent;
        int hpPercent;
        int xpPercent;

        Boolean showAbilities = false;

        Boolean pokémonScreenMenu = false;
        string pokémonScreenString = "use";


        Boolean firstBadge = false;
        Boolean secondBadge = false;
        Boolean thirdBadge = false;
        Boolean fourthBadge = false;
        Boolean fithBadge = false;
        Boolean sixthBadge = false;

        Boolean hasBike = false;
        Boolean usingBike = false;

        int itemSelected = 0;

        int pokémonSelected = 0;

        int playerX = 300;
        int playerY = 300;

        int playerBuildX = 300;
        int playerBuildY = 500;

        int X;
        int Y;

        int sudowoodoX = 1980;
        int sudowoodoY = 3780;
        Boolean sudowoodoLiving = true;
        Boolean sudowoodoFighting = false;
        
        int treex;
        int treey;

        int treex2;
        int treey2;

        int grassx;
        int grassy;
        

        int itemx = 50;
        int itemy = 50;

        Image[] rightMove = { Properties.Resources.rightStationary, 
                                   Properties.Resources.rightMotion1, 
                                   Properties.Resources.rightMotion2};

        Image[] leftMove = { Properties.Resources.leftStationary, 
                                   Properties.Resources.leftMotion1, 
                                   Properties.Resources.leftMotion2};

        Image[] upMove = { Properties.Resources.upStationary, 
                                   Properties.Resources.upMotion1, 
                                   Properties.Resources.upMotion2};

        Image[] downMove = { Properties.Resources.downStationary, 
                                   Properties.Resources.downMotion1, 
                                   Properties.Resources.downMotion2};
        

        Image[] itemImage = { Properties.Resources.boatImage, 
                                   Properties.Resources.pokéball, 
                                   Properties.Resources.healthPotion,
                            Properties.Resources.greatBallImage};

        Image[] pokémonImage = { Properties.Resources.pikachuImage, 
                                   Properties.Resources.squeedleImage, 
                                   Properties.Resources.geodudeImage,
                                   Properties.Resources.pidgeyImage,
                                   Properties.Resources.caterpieImage,
                               Properties.Resources.sudowoodoImage,
                               Properties.Resources.hoothootImage,
                               Properties.Resources.spinarakIamge};

        Image[] pokémonImageBack = { Properties.Resources.pikachuBack, 
                                   Properties.Resources.squeedleBack, 
                                   Properties.Resources.geodudeBack,
                                   Properties.Resources.pidgeyBack,
                                   Properties.Resources.caterpieBack,
                                   Properties.Resources.sudowoodoBack,
                                   Properties.Resources.hoothootBack,
                                   Properties.Resources.spinarakBack};


        Image[] trainerImage = { Properties.Resources.trainerUp, 
                                   Properties.Resources.trainerDown, 
                                   Properties.Resources.trainerLeft, 
                                   Properties.Resources.trainerRight};

        Image[] signImage = { Properties.Resources.sign, 
                                   Properties.Resources.trainerDown}; 

        Image [] gymImage = { Properties.Resources.gymOneImage, 
                                   Properties.Resources.gymTwoImage, 
                                   Properties.Resources.gymThreeImage, 
                                   Properties.Resources.gymFourImage, 
                                   Properties.Resources.gymFiveImage, 
                                   Properties.Resources.gymSixImage};

        Image[] flowerImage = { Properties.Resources.flowers1, 
                                   Properties.Resources.flowers2, 
                                   Properties.Resources.flowers3, 
                                   Properties.Resources.flowers4};

        Image[] houseImage = { Properties.Resources.houseSmall, 
                                   Properties.Resources.houseWide};


        Image treeImage = Properties.Resources.tree;
        Image martImage = Properties.Resources.mart;      
        Image martMat = Properties.Resources.martMat;
        Image martBars = Properties.Resources.martBars;
        Image grassImage = Properties.Resources.grass;
        Image pokéball = Properties.Resources.pokéball;
        Image pokémonCenterImage = Properties.Resources.pokémonCenter;
        Image bankImage = Properties.Resources.bankImage;
        Image sudowoodoMapImage = Properties.Resources.sudowoodoMapImage;
        Image archImage = Properties.Resources.arch;
        

        List<Tree> treeList = new List<Tree>();
        List<Mart> martList = new List<Mart>();
        List<Sign> signList = new List<Sign>();
        List<Item> itemList = new List<Item>();
        List<Item> shopList = new List<Item>();
        List<Grass> grassList = new List<Grass>();
        List<Pokémon> pokémonList = new List<Pokémon>();        
        List<Trainer> trainerList = new List<Trainer>();
        List<Trainer> gymTrainerList = new List<Trainer>();
        List<Pokémon> enemyPokémonList = new List<Pokémon>();
        List<PokémonCenter> pokémonCenterList = new List<PokémonCenter>();
        List<Pokémon> swapList = new List<Pokémon>();
        List<Bank> bankList = new List<Bank>();
        List<Gym> gymList = new List<Gym>();
        List<House> houseList = new List<House>();

        

        public Form1()
        {
            InitializeComponent();
            gameTimer.Start();

            X = X + 300;
            Y = Y + 300;
            
            
            #region setting up map

            for (int i = 0; i < 1; i++)
            {
                PokémonCenter pc = new PokémonCenter(90, 180, pokémonCenterImage);
                pokémonCenterList.Add(pc);
            }
            for (int i = 0; i < 1; i++)
            {
                Item it = new Item("HealthPotion", "Heals A Pokémon", itemImage, 2, 0, 0, 100);
                itemList.Add(it);
            }
            for (int i = 0; i < 1; i++)
            {
                Item it = new Item("Pokéball", "Used to catch a Pokémon", itemImage, 1, 0, 0, 100);
                itemList.Add(it);
            }            
            for (int i = 0; i < 1; i++)
            {               
                Pokémon p = new Pokémon("Pikachu", pikachuDescription, pokémonImage, pokémonImageBack, 0, 0, 0, "tackle", "thundershock", "--", "--", pikachuBaseHp + pikachuHpPerLevel * 25, 10, pikachuBaseHp, pikachuHpPerLevel, 50, 5, false, 10, false);
                pokémonList.Add(p);
            }
            for (int i = 0; i < 1; i++)
            {
                Pokémon p = new Pokémon("Geodude", "Geodude description", pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "--", "--", "--", geodudeBaseHp + geodudeHpPerLevel * 3, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 3, false, 700, false);
                pokémonList.Add(p);
            } 
   
            #region items

            //shop items
            for (int i = 0; i < 1; i++)
            {
                Item s = new Item("Boat", "Allows you to cross water", itemImage, 0, 0, 0, 100);
                shopList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Item s = new Item("HealthPotion", "Heals A Pokémon", itemImage, 2, 0, 0, 100);
                shopList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Item s = new Item("Pokéball", "Used to catch a Pokémon", itemImage, 1, 0, 0, 100);
                shopList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Item s = new Item("Greatball", "Used to catch a Pokémon", itemImage, 3, 0, 0, 500);
                shopList.Add(s);
            }   
            #endregion

            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("Jay", trainerImage, 480, 480, 1, "Up", 14);
                trainerList.Add(t);
            }

            for (int i = 0; i < 1; i++)
            {
                Mart m = new Mart(480, 120, martImage);
                martList.Add(m);
            }

            //sign
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(450, 270, "StartCity", signImage, 0);
                signList.Add(s);
            }


            #region grass
            //creates grass
            grassx = 480;
            grassy = 600;
            //grass 1 x
            for (int i = 0; i < 64; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 1);
                grassList.Add(g);

                grassx = grassx + 60;
                if (i == 15)
                {
                    grassy = grassy + 60;
                    grassx = 480;
                }
                if (i == 31)
                {
                    grassy = grassy + 60;
                    grassx = 480;
                }
                if (i == 47)
                {
                    grassy = grassy + 60;
                    grassx = 480;
                }
            }
            //grass 2 y
            grassy = grassy + 60;
            grassx = grassx - 240;
            for (int i = 0; i < 40; i++)
            {                
                Grass g = new Grass(grassx, grassy, grassImage, 1);
                grassList.Add(g);

                grassy = grassy + 60;
                if (i == 9)
                {
                    grassx = grassx + 60;
                    grassy = 840;
                }
                if (i == 19)
                {
                    grassx = grassx + 60;
                    grassy = 840;
                }
                if (i == 29)
                {
                    grassx = grassx + 60;
                    grassy = 840;
                }
            }
            //grass 1st grass after allitum y
            grassx = 1980;
            grassy = 1320;
            for (int i = 0; i < 20; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 2);
                grassList.Add(g);

                grassx = grassx + 60;
                if (i == 4)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 9)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 14)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 19)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
            }
            //grass4 2nd grass after allitum x
            grassx = 1980;
            grassy = 1080;
            for (int i = 0; i < 40; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 2);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 9)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 19)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 29)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 39)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
            }


            grassx = 2940;
            grassy = 1080;
            //grass5 3nd grass after allitum y
            for (int i = 0; i < 24; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 2);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 3)
                {
                    grassy = grassy + 60;
                    grassx = 2940;
                }
                if (i == 7)
                {
                    grassy = grassy + 60;
                    grassx = 2940;
                }
                if (i == 11)
                {
                    grassy = grassy + 60;
                    grassx = 2940;
                }
                if (i == 15)
                {
                    grassy = grassy + 60;
                    grassx = 2940;
                }
                if (i == 19)
                {
                    grassy = grassy + 60;
                    grassx = 2940;
                }
                if (i == 23)
                {
                    grassy = grassy + 60;
                    grassx = 2940;
                }
            }
            //first grass after sungrey x
            grassx = 2850;
            grassy = 2580;
            for (int i = 0; i < 90; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 3);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 14)
                {
                    grassy = grassy + 60;
                    grassx = 2850;
                }
                if (i == 29)
                {
                    grassy = grassy + 60;
                    grassx = 2850;
                }
                if (i == 44)
                {
                    grassy = grassy + 60;
                    grassx = 2850;
                }
                if (i == 59)
                {
                    grassy = grassy + 60;
                    grassx = 2850;
                }
                if (i == 74)
                {
                    grassy = grassy + 60;
                    grassx = 2850;
                }                
            }

            //first grass after dewford
            grassx = 840;
            grassy = 2580;
            for (int i = 0; i < 114; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 4);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 18)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 37)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 56)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 75)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 94)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
            }
            //2nd grass after dewford y
            grassx = 840;
            grassy = 2940;
            for (int i = 0; i < 32; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 4);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 3)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 7)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 11)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 15)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 19)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 23)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 27)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
                if (i == 31)
                {
                    grassy = grassy + 60;
                    grassx = 840;
                }
            }
            //3rd grass after dewford x
            grassx = 1080;
            grassy = 3300;
            for (int i = 0; i < 20; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 4);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 9)
                {
                    grassy = grassy + 60;
                    grassx = 1080;
                }
                if (i == 19)
                {
                    grassy = grassy + 60;
                    grassx = 1080;
                }  
            }
            //4th grass after dewford y
            grassx = 1440;
            grassy = 3420;
            for (int i = 0; i < 40; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 4);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 3)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 7)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 11)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 15)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 19)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 23)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 27)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 31)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 35)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
                if (i == 39)
                {
                    grassy = grassy + 60;
                    grassx = 1440;
                }
            }
            //1st grass after sudowoodo x
            grassx = 1980;
            grassy = 3600;
            for (int i = 0; i < 90; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 5);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 29)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
                if (i == 59)
                {
                    grassy = grassy + 60;
                    grassx = 1980;
                }
            }
            //valley after sudowoodo
            grassx = 2880;
            grassy = 3780;
            for (int i = 0; i < 63; i++)
            {
                Grass g = new Grass(grassx, grassy, grassImage, 5);
                grassList.Add(g);

                grassx = grassx + 60;

                if (i == 8)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
                if (i == 17)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
                if (i == 26)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
                if (i == 35)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
                if (i == 44)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
                if (i == 53)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
                if (i == 62)
                {
                    grassy = grassy + 60;
                    grassx = 2880;
                }
            }
            #endregion

            #region trees
            treex = 0;
            //wall 3
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex, 0, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
            treey = 60;
            //wall 2
            for (int i = 0; i < 9; i++)
            {
                Tree t = new Tree(540, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            treex = 240;
            //wall 1
            for (int i = 0; i < 20; i++)
            {
                Tree t = new Tree(treex, 540, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }

            treey = 0;
            //wall 4
            for (int i = 0; i < 15; i++)
            {
                Tree t = new Tree(-60, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            treex = 0;
            //wall 5
            for (int i = 0; i < 20; i++)
            {
                Tree t = new Tree(treex, 840, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
            //wall 6
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(1140, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }            

            treey = 540;
            //wall 7
            for (int i = 0; i < 16; i++)
            {
                Tree t = new Tree(1440, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }            
            treey = 1500;
            treex = 720;
            //wall 8
            for (int i = 0; i < 8; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
            
            treey = 1560;
            //wall 9
            for (int i = 0; i < 8; i++)
            {
                Tree t = new Tree(720, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            treex = 720;
            //wall 10
            for (int i = 0; i < 26; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
        
            treey = 1500;
            treex = 1440;
            //wall 11
            for (int i = 0; i < 8; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
            treey = 1020;
            //wall 12
            for (int i = 0; i < 9; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            treex = treex + 360;
            treey = 1320;
            //wall 13
            for (int i = 0; i < 13; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;

                treex2 = treex;
                treey2 = 1320; 
            }
            

            treey = 1020;
            treex = treex - 300;
            //wall 14
            for (int i = 0; i < 20; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }

            //wall 21
            for (int i = 0; i < 7; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }

            //wall 20
            for (int i = 0; i < 15; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }

            //wall 19
            for (int i = 0; i < 25; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }

           
            //wall 15
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }


            //wall 16
            for (int i = 0; i < 15; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 + 60;
            }


            //wall 17
            for (int i = 0; i < 15; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }
            //wall 20
            for (int i = 0; i < 5; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 + 60;
            }
            //wall 21
            for (int i = 0; i < 50; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 - 60;
            }
            //wall 22
            for (int i = 0; i < 50; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex - 60;
            }
            //wall 23
            for (int i = 0; i < 15; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 + 60;
            }
            //wall 24
            for (int i = 0; i < 5; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            //wall 25
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }
            //wall 26
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
            //wall 27
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 + 60;
            }
            //wall 28
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            //wall 29
            for (int i = 0; i < 11; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }
            //wall 30
            for (int i = 0; i < 5; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }

            treey2 = 3780;
            //wall 31
            for (int i = 0; i < 5; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 + 60;
            }
            treey = treey - 300;
            treex = treex - 60;
            //wall 32
            for (int i = 0; i < 5; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treey = treey + 60;
            }
            treey2 = 3780;
            //wall 33 
            for (int i = 0; i < 13; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }

            treey = treey - 300;
            //wall 34
            for (int i = 0; i < 45; i++)
            {
                Tree t = new Tree(treex, treey, treeImage);
                treeList.Add(t);
                treex = treex + 60;
            }
            //wall 35
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 + 60;
            }
            //treex2 = treex2 + 500;
            //wall 36
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }
            //wall 37
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treey2 = treey2 - 60;
            }
            //wall 38
            for (int i = 0; i < 10; i++)
            {
                Tree t = new Tree(treex2, treey2, treeImage);
                treeList.Add(t);
                treex2 = treex2 + 60;
            }
            
            #endregion
            
            for (int i = 0; i < 1; i++)
            {
                PokémonCenter pc = new PokémonCenter(1200, 1770, pokémonCenterImage);
                pokémonCenterList.Add(pc);
            }

            for (int i = 0; i < 1; i++)
            {
                Mart m = new Mart(990, 1860, martImage);
                martList.Add(m);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(1050, 1770, "Welcome to the city of: Allitum", signImage, 0);
                signList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(1170, 1560, "The city of Allitum is the home of many eager rookie trainers", signImage, 1);
                signList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(1950, 1560, "Be sure to buy pokéballs to catch more pokémon!", signImage, 1);
                signList.Add(s);
            }

            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("Allitum1", trainerImage, 900, 1800, 1, "Up", 14);
                trainerList.Add(t);
            }
            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("Allitum2", trainerImage, 810, 1710, 1, "Right", 14);
                trainerList.Add(t);
            }

            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("RouteOne1", trainerImage, 2670, 1110, 2, "Down", 27);
                trainerList.Add(t);
            }
            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("RouteOne2", trainerImage, 2790, 1140, 2, "Left", 27);
                trainerList.Add(t);
            }


            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("Allitum2", trainerImage, 810, 1710, 1, "Right", 14);
                trainerList.Add(t);
            }


            for (int i = 0; i < 1; i++)
            {
                PokémonCenter pc = new PokémonCenter(3420, 1650, pokémonCenterImage);
                pokémonCenterList.Add(pc);
            }
            for (int i = 0; i < 1; i++)
            {
                Mart m = new Mart(3600, 1800, martImage);
                martList.Add(m);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(3180, 1500, "Try out your skills at the gym in town", signImage, 1);
                signList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(3270, 1590, "Welcome to the city of: Sungrey", signImage, 0);
                signList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Gym g = new Gym(3150, 1890, gymImage, 0);
                gymList.Add(g);
            }            
            for (int i = 0; i < 1; i++)
            {
                Mart m = new Mart(2250, 2700, martImage);
                martList.Add(m);
            } 
            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("Dewford1", trainerImage, 2220, 2730, 1, "Down", 14);
                trainerList.Add(t);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(2700, 2700, "Welcome to the town of: Dewford", signImage, 0);
                signList.Add(s);
            }
            for (int i = 0; i < 1; i++)
            {
                Sign s = new Sign(1800, 3900, "Sometimes I swear I hear the trees talk...", signImage, 1);
                signList.Add(s);
            }

            for (int i = 0; i < 1; i++)
            {
                Trainer t = new Trainer("BikeMan", trainerImage, 3060, 4290, 1, "Down", 576);
                trainerList.Add(t);
            }
            for (int i = 0; i < 1; i++)
            {
                House h = new House(3090, 4260, houseImage, 0);
                houseList.Add(h);
            }

            for (int i = 0; i < 1; i++)
            {
                House h = new House(390, 390, houseImage, 0);
                houseList.Add(h);
            }
            #endregion


            
        }

        #region Key up/down
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
                    case Keys.Escape:
                    escKeyDown = true;
                    break;
                    case Keys.Tab:
                    tabKeyDown = true;
                    break;   
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;
                case Keys.Escape:
                    escKeyDown = false;
                    break;
                case Keys.Tab:
                    tabKeyDown = false;
                    break;
                default:
                    break;
            }

        }
        #endregion   

        private void gameTimer_Tick(object sender, EventArgs e)
        {    
            //set hp for each pokémon
            for (int i = 0; i < pokémonList.Count(); i++)
            {
                pokémonList[i].maxHealth = pokémonList[i].baseHp + pokémonList[i].hpPerLevl * pokémonList[i].level;
             
                pokémonList[i].maxHealth = pokémonList[i].baseHp + pokémonList[i].hpPerLevl * pokémonList[i].level;
       
                if (pokémonList[i].xp >= pokémonList[i].level * (pokémonList[i].level + 100))
                {
                    pokémonList[i].xp = pokémonList[i].xp - pokémonList[i].level * (pokémonList[i].level + 100);                  
                    pokémonList[i].level++;
                }
                if (pokémonList[i].health > pokémonList[i].maxHealth)
                {
                    pokémonList[i].health = pokémonList[i].maxHealth;
                }
            }

            for (int i = 0; i < enemyPokémonList.Count(); i++)
            {               
                enemyPokémonList[i].maxHealth = enemyPokémonList[i].baseHp + (enemyPokémonList[i].hpPerLevl * enemyPokémonList[i].level);
            }
            if (enemyPokémonList.Count() != 0)
            {
                enemyHpPercent = (enemyPokémonList[0].health * 100) / (enemyPokémonList[0].maxHealth);
            }
            if (pokémonList.Count() != 0)
            {
                hpPercent = (pokémonList[0].health * 100) / pokémonList[0].maxHealth;
                xpPercent = (pokémonList[0].xp * 100) / (((pokémonList[0].level * (pokémonList[0].level + 100)) / 2));
            }
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            if (enemyPokémonList.Count() != 0)
            {
                catchResistance = enemyPokémonList[0].catchResistance;
            }
            if (msgShowing == true)
            {
                msgCounter++;
            }
            if (msgCounter == 100)
            {
                msgShowing = false;
                msgCounter = 0;
                purchaseComplete = false;
            }

            #region gameScreen
            if (currentScreen == "game")
            {           
                BackgroundImage = null;

                if (escKeyDown == true && inGameMenu == false && inGameyn == false)
                {
                    inGameMenu = true;
                    escKeyDown = false;
                }
                if (spaceKeyDown == true && inGameMenu == false && inGameyn == false && hasBike == true)
                {
                    usingBike = !usingBike;
                    spaceKeyDown = false;
                }

                #region Collision

                #region trees
                for (int i = 0; i < treeList.Count(); i++)
                {
                    if (treeList[i].x >= 270 && treeList[i].x <= 300 && treeList[i].y == 240)
                    {
                        upBlocked = true;
                    }
                    if (treeList[i].x == 330 && treeList[i].y <= 300 && treeList[i].y >= 270)
                    {
                        rightBlocked = true;
                    }
                    if (treeList[i].x == 240 && treeList[i].y <= 300 && treeList[i].y >= 270)
                    {
                        leftBlocked = true;
                    }
                    if (treeList[i].x >= 270 && treeList[i].x <= 300 && treeList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }
                #endregion

                #region marts
                for (int i = 0; i < martList.Count(); i++)
                {
                    if (martList[i].x == 270 && martList[i].y == 240)
                    {
                        upBlocked = true;
                    }
                    if (martList[i].x == 300 && martList[i].y == 240)
                    {
                        upInteraction = "martEntrance";
                    }
                    if (martList[i].x == 330 && martList[i].y <= 300 && martList[i].y >= 270)
                    {
                        rightBlocked = true;
                    }
                    if (martList[i].x == 240 && martList[i].y <= 300 && martList[i].y >= 270)
                    {
                        leftBlocked = true;
                    }
                    if (martList[i].x >= 270 && martList[i].x <= 300 && martList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }
                #endregion

                #region pokémonCenter
                for (int i = 0; i < pokémonCenterList.Count(); i++)
                {
                    if (pokémonCenterList[i].x <= 300 && pokémonCenterList[i].x >= 180 && pokémonCenterList[i].y == 210)
                    {
                        upBlocked = true;
                    }
                    if (pokémonCenterList[i].x == 240 && pokémonCenterList[i].y == 210)
                    {
                        upInteraction = "pokémonCenterEntrance";
                    }
                    if (pokémonCenterList[i].x == 330 && pokémonCenterList[i].y <= 300 && pokémonCenterList[i].y >= 240)
                    {
                        rightBlocked = true;
                    }
                    if (pokémonCenterList[i].x == 150 && pokémonCenterList[i].y <= 300 && pokémonCenterList[i].y >= 240)
                    {
                        leftBlocked = true;
                    }
                    if (pokémonCenterList[i].x <= 300 && pokémonCenterList[i].x >= 180 && pokémonCenterList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }
                #endregion

                #region gyms
                for (int i = 0; i < gymList.Count(); i++)
                {
                    if (gymList[i].x <= 300 && gymList[i].x >= 60 && gymList[i].y == 120)
                    {
                        upBlocked = true;
                    }
                    if (gymList[i].x == 180 && gymList[i].y == 120)
                    {
                        upInteraction = "gymOneEnterance";
                    }
                    if (gymList[i].x == 330 && gymList[i].y <= 300 && gymList[i].y >= 150)
                    {
                        rightBlocked = true;
                    }
                    if (gymList[i].x == 30 && gymList[i].y <= 300 && gymList[i].y >= 150)
                    {
                        leftBlocked = true;
                    }
                    if (gymList[i].x <= 300 && gymList[i].x >= 60 && gymList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }
                #endregion

                #region banks
                for (int i = 0; i < bankList.Count(); i++)
                {
                    if (bankList[i].x <= 300 && bankList[i].x >= 240 && bankList[i].y == 240)
                    {
                        upBlocked = true;
                    }
                    if (bankList[i].x == 270 && bankList[i].y == 240)
                    {
                        upInteraction = "bankEntrance";
                    }
                    if (bankList[i].x == 330 && bankList[i].y <= 300 && bankList[i].y >= 270)
                    {
                        rightBlocked = true;
                    }
                    if (bankList[i].x == 210 && bankList[i].y <= 300 && bankList[i].y >= 270)
                    {
                        leftBlocked = true;
                    }
                    if (bankList[i].x <= 300 && bankList[i].x >= 240 && bankList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }
                #endregion

                #region signs
                for (int i = 0; i < signList.Count(); i++)
                {
                    if (signList[i].x == 300 && signList[i].y == 270)
                    {
                        upBlocked = true;
                        upInteraction = "sign";
                        signNumber = i;
                    }
                    if (signList[i].x == 330 && signList[i].y == 300)
                    {
                        rightBlocked = true;
                    }
                    if (signList[i].x == 270 && signList[i].y == 300)
                    {
                        leftBlocked = true;
                    }
                    if (signList[i].x == 300 && signList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }
#endregion

                #region grass
                for (int i = 0; i < grassList.Count(); i++)
                {
                    if (grassList[i].x >= 270 && grassList[i].x <= 300 && grassList[i].y >= 270 && grassList[i].y <= 300)
                    {
                        inGrass = true;
                    }
                }
                #endregion

                #region trainers
                for (int i = 0; i < trainerList.Count(); i++)
                {
                    if (trainerList[i].x == 300 && trainerList[i].y == 270)
                    {                       
                        upBlocked = true;
                        upInteraction = "Trainer";
                        trainerNumber = i;
                    }
                    if (trainerList[i].x == 300 && trainerList[i].y == 330)
                    {                       
                        downBlocked = true;
                        downInteraction = "Trainer";
                        trainerNumber = i;
                    }
                    if (trainerList[i].x == 270 && trainerList[i].y == 300)
                    {                       
                        leftBlocked = true;
                        leftInteraction = "Trainer";
                        trainerNumber = i;
                    }
                    if (trainerList[i].x == 330 && trainerList[i].y == 300)
                    {                        
                        rightBlocked = true;
                        rightInteraction = "Trainer";
                        trainerNumber = i;
                    }
                }
                #endregion

                #region houses

                for (int i = 0; i < houseList.Count(); i++)
                {
                    if (houseList[i].x == 270 || houseList[i].x == 300 && houseList[i].y == 240)
                    {
                        upBlocked = true;
                    }                   
                    if (houseList[i].x == 330 && houseList[i].y <= 300 && houseList[i].y >= 270)
                    {
                        rightBlocked = true;
                    }
                    if (houseList[i].x == 240 && houseList[i].y <= 300 && houseList[i].y >= 270)
                    {
                        leftBlocked = true;
                    }
                    if (houseList[i].x >= 270 && houseList[i].x <= 300 && houseList[i].y == 330)
                    {
                        downBlocked = true;
                    }
                }

                #endregion


                #endregion

                if (inGameMenu == false && inGameyn == false)
                {
                    #region movement

                    #region keyDowns
                    if (direction == "null")
                    {
                        if (aKeyDown == true)
                        {
                            if (leftInteraction == "null" && leftBlocked == false)
                            {
                                EnemyFound();
                                direction = "Left";
                                drawDirection = "Left";
                                directionTicks = 10;
                            }
                            if (leftInteraction == "Trainer")
                            {
                                inGameyn = true;
                                leftInteraction = "null";
                                Message("Hello would you like to battle?");
                                msgShowing = true;
                            } 
                        }
                        if (sKeyDown == true)
                        {
                            if (downInteraction == "null" && downBlocked == false)
                            {
                                EnemyFound();
                                direction = "Down";
                                drawDirection = "Down";
                                directionTicks = 10;                                
                            }
                            if (downInteraction == "Trainer")
                            {
                                inGameyn = true;
                                downInteraction = "null";
                                Message("Hello would you like to battle?");
                                msgShowing = true;
                            }                       
                        }

                        if (wKeyDown == true)
                        {
                            if (upInteraction == "null" && upBlocked == false)
                            {
                                EnemyFound();
                                direction = "Up";
                                drawDirection = "Up";
                                directionTicks = 10;
                            }
                            if (upInteraction == "martEntrance")
                            {
                                ScreenChange();
                                upInteraction = "null";
                            }
                            if (upInteraction == "sign")
                            {
                                Message(signList[signNumber].msg);
                                msgShowing = true;
                                upInteraction = "null";

                            }
                            if (upInteraction == "Trainer")
                            {
                                inGameyn = true;
                                upInteraction = "null";
                                Message("Hello would you like to battle?");
                                msgShowing = true;
                            }
                            if (upInteraction == "pokémonCenterEntrance")
                            {
                                ScreenChange();
                                upInteraction = "null";
                            }
                            if (upInteraction == "bankEntrance")
                            {
                                ScreenChange();
                                upInteraction = "null";
                            }
                            if (upInteraction == "gymOneEnterance")
                            {
                                if (firstBadge == false)
                                {
                                    ScreenChange();
                                    upInteraction = "null";
                                    inGym = true;
                                }
                                else
                                {
                                    Message("You already have the badge from this gym!");
                                    msgShowing = true;
                                }
                            }
                            if (sudowoodoLiving == true)
                            {
                                if (X == 1980 || X == 2010)
                                {
                                    if (Y == 3840)
                                    {
                                        currentScreen = "fightScreen";
                                        Pokémon p = new Pokémon("Sudowoodo", sudowoodoDescription, pokémonImage, pokémonImageBack, 5, 0, 0, "rockthrow", "flail", "lowkick", "rockthrow", sudowoodoBaseHp + (sudowoodoHpPerLevel * 20), 10, sudowoodoBaseHp, sudowoodoHpPerLevel, 50, 20, false, 1500, false);
                                        enemyPokémonList.Add(p);
                                        inFight = true;
                                        sudowoodoFighting = true;
                                    }
                                }
                            }
                        }

                        if (dKeyDown == true)
                        {
                            if (rightInteraction == "null" && rightBlocked == false)
                            {
                                EnemyFound();
                                direction = "Right";
                                drawDirection = "Right";
                                directionTicks = 10;
                            }
                            if (rightInteraction == "Trainer")
                            {
                                inGameyn = true;
                                rightInteraction = "null";
                                Message("Hello would you like to battle?");
                                msgShowing = true;
                            } 
                        }
                        //if (tabKeyDown == true)
                        //{
                        //    if (hasBike == true)
                        //    {
                        //        usingBike = !usingBike;
                        //    }
                        //    tabKeyDown = false;
                        //}

                    }
                    #endregion

                    #region Moving
                    if (directionTicks == 0)
                    {
                        direction = "null";
                    }
                    if (directionTicks > 0 && direction != "null")
                    {
                        directionTicks--;
                        inGrass = false;
                        if (direction == "Left")
                        {
                            int L = 3;
                            for (int i = 0; i < treeList.Count(); i++)
                            {
                                treeList[i].x = treeList[i].x + L;
                            }
                            for (int i = 0; i < martList.Count(); i++)
                            {
                                martList[i].x = martList[i].x + L;
                            }
                            for (int i = 0; i < signList.Count(); i++)
                            {
                                signList[i].x = signList[i].x + L;
                            }
                            for (int i = 0; i < grassList.Count(); i++)
                            {
                                grassList[i].x = grassList[i].x + L;
                            }
                            for (int i = 0; i < trainerList.Count(); i++)
                            {
                                trainerList[i].x = trainerList[i].x + L;
                            }
                            for (int i = 0; i < pokémonCenterList.Count(); i++)
                            {
                                pokémonCenterList[i].x = pokémonCenterList[i].x + L;
                            }
                            for (int i = 0; i < gymList.Count(); i++)
                            {
                                gymList[i].x = gymList[i].x + L;
                            }
                            sudowoodoX = sudowoodoX + L;
                            for (int i = 0; i < houseList.Count(); i++)
                            {
                                houseList[i].x = houseList[i].x + L;
                            }
                            
                            X = X - L;
                        }
                        if (direction == "Down")
                        {
                            int L = -3;
                            for (int i = 0; i < treeList.Count(); i++)
                            {
                                treeList[i].y = treeList[i].y + L;

                            }
                            for (int i = 0; i < martList.Count(); i++)
                            {
                                martList[i].y = martList[i].y + L;
                            }
                            for (int i = 0; i < signList.Count(); i++)
                            {
                                signList[i].y = signList[i].y + L;
                            }
                            for (int i = 0; i < grassList.Count(); i++)
                            {
                                grassList[i].y = grassList[i].y + L;
                            }
                            for (int i = 0; i < trainerList.Count(); i++)
                            {
                                trainerList[i].y = trainerList[i].y + L;
                            }
                            for (int i = 0; i < pokémonCenterList.Count(); i++)
                            {
                                pokémonCenterList[i].y = pokémonCenterList[i].y + L;
                            }
                            for (int i = 0; i < gymList.Count(); i++)
                            {
                                gymList[i].y = gymList[i].y + L;
                            }                            
                            sudowoodoY = sudowoodoY + L;
                            for (int i = 0; i < houseList.Count(); i++)
                            {
                                houseList[i].y = houseList[i].y + L;
                            }
                            Y = Y - L;
                        }
                        if (direction == "Up")
                        {
                            int L = 3;
                            for (int i = 0; i < treeList.Count(); i++)
                            {
                                treeList[i].y = treeList[i].y + L;
                            }
                            for (int i = 0; i < martList.Count(); i++)
                            {
                                martList[i].y = martList[i].y + L;
                            }
                            for (int i = 0; i < signList.Count(); i++)
                            {
                                signList[i].y = signList[i].y + L;
                            }
                            for (int i = 0; i < grassList.Count(); i++)
                            {
                                grassList[i].y = grassList[i].y + L;
                            }
                            for (int i = 0; i < trainerList.Count(); i++)
                            {
                                trainerList[i].y = trainerList[i].y + L;
                            }
                            for (int i = 0; i < pokémonCenterList.Count(); i++)
                            {
                                pokémonCenterList[i].y = pokémonCenterList[i].y + L;
                            }
                            for (int i = 0; i < gymList.Count(); i++)
                            {
                                gymList[i].y = gymList[i].y + L;
                            }
                            sudowoodoY = sudowoodoY + L;
                            for (int i = 0; i < houseList.Count(); i++)
                            {
                                houseList[i].y = houseList[i].y + L;
                            }
                            Y = Y - L;
                        }
                        if (direction == "Right")
                        {
                            int L = -3;

                            for (int i = 0; i < treeList.Count(); i++)
                            {
                                treeList[i].x = treeList[i].x + L;
                            }
                            for (int i = 0; i < martList.Count(); i++)
                            {
                                martList[i].x = martList[i].x + L;
                            }
                            for (int i = 0; i < signList.Count(); i++)
                            {
                                signList[i].x = signList[i].x + L;
                            }
                            for (int i = 0; i < grassList.Count(); i++)
                            {
                                grassList[i].x = grassList[i].x + L;
                            }
                            for (int i = 0; i < trainerList.Count(); i++)
                            {
                                trainerList[i].x = trainerList[i].x + L;
                            }
                            for (int i = 0; i < pokémonCenterList.Count(); i++)
                            {
                                pokémonCenterList[i].x = pokémonCenterList[i].x + L;
                            }
                            for (int i = 0; i < gymList.Count(); i++)
                            {
                                gymList[i].x = gymList[i].x + L;
                            }
                            sudowoodoX = sudowoodoX + L;
                            for (int i = 0; i < houseList.Count(); i++)
                            {
                                houseList[i].x = houseList[i].x + L;
                            }
                            X = X - L;
                        }
                    }
                    if (directionTicks < 3)
                    {
                        drawTicks = 1;
                    }
                    if (directionTicks > 3 && directionTicks < 6)
                    {
                        drawTicks = 2;
                    }
                    if (directionTicks == 0 || directionTicks > 6)
                    {
                        drawTicks = 0;
                    }

                    upBlocked = false;
                    downBlocked = false;
                    leftBlocked = false;
                    rightBlocked = false;

                    upInteraction = "null";
                    downInteraction = "null";
                    rightInteraction = "null";
                    leftInteraction = "null";
                    #endregion

                    #endregion

                    menuSelected = "items";
                    ynSelected = "yes";
                    itemSelected = 0;
                    
                }
                if (inGameMenu == true)
                {
                    #region MenuSelection
                    if (wKeyDown == true)
                    {
                        if (menuSelected == "pokémon" && wKeyDown == true)
                        {
                            menuSelected = "items";
                            wKeyDown = false;
                        }
                        if (menuSelected == "player" && wKeyDown == true)
                        {
                            menuSelected = "pokémon";
                            wKeyDown = false;
                        }
                        if (menuSelected == "exit" && wKeyDown == true)
                        {
                            menuSelected = "player";
                            wKeyDown = false;
                        }
                        if (menuSelected == "items" && wKeyDown == true)
                        {
                            menuSelected = "exit";
                            wKeyDown = false;
                        }
                    }
                    if (sKeyDown == true)
                    {
                        if (menuSelected == "exit" && sKeyDown == true)
                        {
                            menuSelected = "items";
                            sKeyDown = false;
                        }

                        if (menuSelected == "player" && sKeyDown == true)
                        {
                            menuSelected = "exit";
                            sKeyDown = false;
                        }



                        if (menuSelected == "pokémon" && sKeyDown == true)
                        {
                            menuSelected = "player";
                            sKeyDown = false;
                        }

                        if (menuSelected == "items" && sKeyDown == true)
                        {
                            menuSelected = "pokémon";
                            sKeyDown = false;
                        }
                    }

                    if (spaceKeyDown == true && inGameMenu == true)
                    {
                        if (menuSelected == "items")
                        {
                            currentScreen = "itemsScreen";
                        }
                        if (menuSelected == "pokémon")
                        {
                            currentScreen = "pokémonScreen";
                            pokémonScreenString = "use";
                        }
                        if (menuSelected == "player")
                        {
                            currentScreen = "playerScreen";
                        }
                        if (menuSelected == "exit")
                        {
                            inGameMenu = false;
                        }
                        spaceKeyDown = false;
                    }
                    if (escKeyDown == true && inGameMenu == true)
                    {
                        inGameMenu = false;
                        escKeyDown = false;
                    }
                    #endregion
                }
                if (inGameyn == true)
                {
                    #region ynSelection

                    if (wKeyDown == true)
                    {
                        if (ynSelected == "yes" && wKeyDown == true)
                        {
                            ynSelected = "no";
                            wKeyDown = false;
                        }
                        if (ynSelected == "no" && wKeyDown == true)
                        {
                            ynSelected = "yes";
                            wKeyDown = false;
                        }
                    }
                    if (sKeyDown == true)
                    {
                        if (ynSelected == "yes" && sKeyDown == true)
                        {
                            ynSelected = "no";
                            sKeyDown = false;
                        }
                        if (ynSelected == "no" && sKeyDown == true)
                        {
                            ynSelected = "yes";
                            sKeyDown = false;
                        }
                    }

                    if (spaceKeyDown == true && inGameyn == true && msgShowing == false)
                    {
                        if (ynSelected == "yes")
                        {
                            //starts fight
                            currentScreen = "fightScreen";

                            
                            if (trainerList[trainerNumber].name == "Jay")
                            {
                                Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 2, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 2, false, 1000, false);
                                enemyPokémonList.Add(p);

                                Pokémon p2 = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "tackle", "tackle", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 1, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 1, false, 700, false);
                                enemyPokémonList.Add(p2);

                                bounty = trainerList[trainerNumber].bounty;
                            }
                            if (trainerList[trainerNumber].name == "Allitum1")
                            {
                                Pokémon p = new Pokémon("Geodude", geodudeDescription, pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "tackle", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 5, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 5, false, 1000, false);
                                enemyPokémonList.Add(p);
                                   
                                bounty = trainerList[trainerNumber].bounty;
                            }
                            if (trainerList[trainerNumber].name == "Allitum2")
                            {
                                Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "tackle", "tackle", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 6, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 6, false, 1000, false);
                                enemyPokémonList.Add(p);
                                   
                                bounty = trainerList[trainerNumber].bounty;
                            }
                            if (trainerList[trainerNumber].name == "RouteOne1")
                            {
                                Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "tackle", "bugbite", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 8, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 8, false, 1000, false);
                                enemyPokémonList.Add(p);

                                bounty = trainerList[trainerNumber].bounty;
                            }
                            if (trainerList[trainerNumber].name == "RouteOne2")
                            {
                                Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 9, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 9, false, 1000, false);
                                enemyPokémonList.Add(p);

                                bounty = trainerList[trainerNumber].bounty;
                            }
                            if (trainerList[trainerNumber].name == "Dewford1")
                            {
                                Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 7, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 7, false, 1000, false);
                                enemyPokémonList.Add(p);

                                Pokémon p2 = new Pokémon("Pidgey", pidgeyDescription, pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "gust", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 13, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 12, false, 1000, false);
                                enemyPokémonList.Add(p2);

                                bounty = trainerList[trainerNumber].bounty;
                            }
                            if (trainerList[trainerNumber].name == "BikeMan")
                            {
                                Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 7, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 7, false, 1000, false);
                                enemyPokémonList.Add(p);

                                Pokémon p2 = new Pokémon("Pidgey", pidgeyDescription, pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "gust", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 13, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 13, false, 1000, false);
                                enemyPokémonList.Add(p2);

                                bounty = trainerList[trainerNumber].bounty;
                            }


                            
                            inFight = true;
                            msgShowing = false;
                            msgCounter = 0;
                            showAbilities = false;
                            playerTurn = true;
                        }
                        if (ynSelected == "no")
                        {
                            inGameyn = false;
                            ynSelected = "yes";
                        }                        
                        spaceKeyDown = false;
                    }

                    #endregion
                }
            }
            #endregion

            #region martScreen
            if (currentScreen == "mart")
            {
                BackgroundImage = Properties.Resources.martBackround;
                if (direction == "null")
                {
                    if (aKeyDown == true && playerBuildX != 0)
                    {
                        direction = "Left";
                        drawDirection = "Left";
                        directionTicks = 10;
                    }
                    if (sKeyDown == true && playerBuildY != 540)
                    {
                        direction = "Down";
                        drawDirection = "Down";
                        directionTicks = 10;
                    }
                    if (wKeyDown == true && playerBuildY != 0)
                    {
                        direction = "Up";
                        drawDirection = "Up";
                        directionTicks = 10;
                    }
                    if (dKeyDown == true && playerBuildX != 540)
                    {
                        direction = "Right";
                        drawDirection = "Right";
                        directionTicks = 10;
                    }
                }            

            if (directionTicks == 0)
            {
                direction = "null";
            }
            if (directionTicks > 0 && direction != "null")
            {
                directionTicks--;

                    if (direction == "Left")
                    {
                        int L = 3;

                        playerBuildX = playerBuildX - L;
                    }
                    if (direction == "Down")
                    {
                        int L = -3;

                        playerBuildY = playerBuildY - L;
                    }
                    if (direction == "Up")
                    {
                        int L = 3;
                      
                        playerBuildY = playerBuildY - L;
                   
                    }
                    if (direction == "Right")
                    {
                        int L = -3;

                        playerBuildX = playerBuildX - L;                        
                    }
                }
                if (directionTicks < 3)
                {
                    drawTicks = 1;
                }
                if (directionTicks > 3 && directionTicks < 6)
                {
                    drawTicks = 2;
                }
                if (directionTicks == 0 || directionTicks > 6)
                {
                    drawTicks = 0;
                }

                if (playerBuildY == 540 && spaceKeyDown == true)
                {
                    currentScreen = "shopScreen";
                    spaceKeyDown = false;
                }
                if (playerBuildY == 0 && spaceKeyDown == true)
                {
                    spaceKeyDown = false;
                    currentScreen = "game";
                }
            }
            #endregion

            #region itemScreen
            if (currentScreen == "itemsScreen")
            {
                if (wKeyDown == true)
                {
                    if (itemSelected >= 5)
                    {
                        itemSelected = itemSelected - 5;
                    }
                    wKeyDown = false;
                }
                if (sKeyDown == true)
                {
                    if (itemList.Count() - 1 - itemSelected >= 5)
                    {
                        itemSelected = itemSelected + 5;
                    }
                    sKeyDown = false;
                }
                if (aKeyDown == true)
                {
                    if (itemSelected != 0)
                    {
                        itemSelected--;
                    }
                    aKeyDown = false;
                }
                if (dKeyDown == true)
                {
                    if (itemSelected != itemList.Count() - 1)
                    {
                        itemSelected++;
                    }
                    dKeyDown = false;
                }
                if (spaceKeyDown == true)
                {                    
                    if (itemList[itemSelected].name == "HealthPotion")
                    {
                        currentScreen = "pokémonScreen";
                        pokémonScreenString = "use";
                        spaceKeyDown = false;
                        itemUsing = "HealthPotion";
                    }
                    if (itemList[itemSelected].name == "Pokéball")
                    {
                        if (inFight == true)
                        {
                            if (enemyPokémonList[0].catchResistance != 10000)
                            {
                                currentScreen = "fightScreen";
                                itemUsing = "Pokéball";
                                catchingPokémon = true;
                                catchCounter = 200;
                                catchStrenth = 400;

                                randomNumber = randNum.Next(1, 11);

                                if (randomNumber == 2)
                                {
                                    catchStrenth = catchStrenth + (catchStrenth / 10);
                                }
                                if (randomNumber == 3)
                                {
                                    catchStrenth = catchStrenth + (catchStrenth / 5);
                                }
                                if (randomNumber == 4)
                                {
                                    catchStrenth = catchStrenth + (catchStrenth / 2);
                                }
                                if (randomNumber >= 5 && randomNumber <= 8)
                                {
                                    catchStrenth = catchStrenth * 2;
                                }
                                if (randomNumber == 9)
                                {
                                    catchStrenth = (catchStrenth * 2) + (catchStrenth / 2);
                                }
                                if (randomNumber == 10)
                                {
                                    catchStrenth = (catchStrenth * 2) + (catchStrenth / 2);
                                }
                            }
                            else
                            {
                                Message("You cannot catch another Trainers pokémon!");
                                msgShowing = true;
                            }
                        }
                        else
                        {
                            Message("You are not in a battle!");
                            msgShowing = true;
                        }
                        spaceKeyDown = false;
                    }
                   
                }
                if (escKeyDown == true)
                {
                    if (inFight == false)
                    {
                        currentScreen = "game";
                    }
                    else
                    {
                        currentScreen = "fightScreen";
                    }
                    escKeyDown = false;
                }
            }
            #endregion

            #region pokémonScreen

            if (currentScreen == "pokémonScreen")
            {
                if (inFight == false)
                {
                    if (pokémonScreenMenu == false)
                    {
                        if (wKeyDown == true)
                        {
                            if (pokémonSelected != 0)
                            {
                                pokémonSelected--; ;
                            }
                            wKeyDown = false;
                        }
                        if (sKeyDown == true)
                        {
                            if (pokémonSelected != pokémonList.Count() - 1)
                            {
                                pokémonSelected++;
                            }
                            sKeyDown = false;
                        }
                    }
                    else
                    {
                        if (wKeyDown == true)
                        {
                            if (pokémonScreenString == "info")
                            {
                                pokémonScreenString = "use";
                            }
                            wKeyDown = false;
                        } if (sKeyDown == true)
                        {
                            if (pokémonScreenString == "use")
                            {
                                pokémonScreenString = "info";
                            }
                            sKeyDown = false;
                        }
                    }
                    
                if (spaceKeyDown == true && pokémonScreenMenu == false)
                {                    
                    if (pokémonList[pokémonSelected].name != "Exit")
                    {
                        pokémonScreenMenu = true;
                        spaceKeyDown = false;
                    }
                }
                   
                    if (spaceKeyDown == true && pokémonScreenMenu == true)
                    {
                        if (pokémonScreenString == "use")
                        {
                            if (itemList[itemSelected].name == "HealthPotion")
                            {
                                pokémonList[pokémonSelected].health = pokémonList[pokémonSelected].health + healthPotHeal;

                                if (pokémonList[pokémonSelected].health > pokémonList[pokémonSelected].maxHealth)
                                {
                                    pokémonList[pokémonSelected].health = pokémonList[pokémonSelected].maxHealth;
                                }

                                itemList.RemoveAt(itemSelected);
                                Message(pokémonList[pokémonSelected].name + " was healed!");
                                msgShowing = true;
                                pokémonScreenMenu = false;
                            }
                        }
                        if (pokémonScreenString == "info")
                        {
                            currentScreen = "pokémonInfoScreen";
                            pokémonScreenMenu = false;
                        }

                        spaceKeyDown = false;
                    }
                }
                else
                {
                    if (pokémonScreenMenu == false)
                    {
                        if (wKeyDown == true)
                        {
                            if (pokémonSelected != 0)
                            {
                                pokémonSelected--; ;
                            }
                            wKeyDown = false;
                        }
                        if (sKeyDown == true)
                        {
                            if (pokémonSelected != pokémonList.Count() - 1)
                            {
                                pokémonSelected++;
                            }
                            sKeyDown = false;
                        }
                    }
                    else
                    {                        
                        if (wKeyDown == true)
                        {
                            if (pokémonScreenString == "use")
                            {
                                pokémonScreenString = "fight";
                            }
                            if (pokémonScreenString == "info")
                            {
                                pokémonScreenString = "use";
                            }
                            wKeyDown = false;
                        } if (sKeyDown == true)
                        {                            
                            if (pokémonScreenString == "use")
                            {
                                pokémonScreenString = "info";
                            }
                            if (pokémonScreenString == "fight")
                            {
                                pokémonScreenString = "use";
                            }
                            sKeyDown = false;
                        }                        
                    }                    

                    if (spaceKeyDown == true && pokémonScreenMenu == false)
                    {
                        if (pokémonList[pokémonSelected].name == "Exit")
                        {
                            if (inFight == false)
                            {
                                currentScreen = "game";
                                spaceKeyDown = false;
                            }
                            else
                            {
                                currentScreen = "fightScreen";
                                spaceKeyDown = false;
                            }
                        }

                        if (pokémonList[pokémonSelected].name != "Exit")
                        {
                            pokémonScreenMenu = true;
                            spaceKeyDown = false;
                        }
                    }
                    //swaps pokémon
                    if (spaceKeyDown == true && pokémonScreenMenu == true)
                    {
                        if (pokémonScreenString == "fight")
                        {
                            if (pokémonSelected != 0)
                            {
                                currentScreen = "fightScreen";

                                swapList.Add(pokémonList[0]);

                                pokémonList[0] = pokémonList[pokémonSelected];

                                pokémonList[pokémonList.Count() - 1] = (swapList[0]);

                                swapList.Clear();

                                pokémonScreenMenu = false;
                                playerTurn = false;
                            }
                            else
                            {
                                Message("That Pokémon is already fighting!");
                                msgShowing = true;

                            }
                        }
                        if (pokémonScreenString == "use")
                        {
                            if (itemList.Count() != 0)
                            {
                                if (itemList[itemSelected].name == "HealthPotion")
                                {
                                    pokémonList[pokémonSelected].health = pokémonList[pokémonSelected].health + healthPotHeal;
                                    itemList.RemoveAt(itemSelected);
                                    Message(pokémonList[pokémonSelected].name + " was healed!");
                                    pokémonScreenMenu = false;
                                    playerTurn = false;
                                }
                            }
                        }
                        if (pokémonScreenString == "info")
                        {
                            currentScreen = "pokémonInfoScreen";
                            pokémonScreenMenu = false;
                        }

                        spaceKeyDown = false;
                    }


                }
                if (escKeyDown == true)
                {
                    if (inFight == false && pokémonScreenMenu == false)
                    {
                        currentScreen = "game";
                       
                    }
                    if (inFight == true && pokémonScreenMenu == false)
                    {
                        currentScreen = "fightScreen";                        
                    }
                    if (pokémonScreenMenu == true)
                    {
                        pokémonScreenMenu = false;                      
                    }
                    
                    escKeyDown = false;
                }

            }

            #endregion

            #region playerScreen

            if (currentScreen == "playerScreen")
            {
                if (spaceKeyDown == true)
                {
                    currentScreen = "game";
                    spaceKeyDown = false;
                }
            }

            #endregion

            #region shopScreen

            if (currentScreen == "shopScreen")
            {
                if (wKeyDown == true)
                {
                    if (itemSelected != 0)
                    {
                        itemSelected--;
                    }
                    wKeyDown = false;
                }
                if (sKeyDown == true)
                {
                    if (itemSelected != shopList.Count() - 1)
                    {
                        itemSelected++;
                    }
                    sKeyDown = false;
                }
                if (spaceKeyDown == true && msgShowing == false)
                {
                    itemList.Add(shopList[itemSelected]);

                    cash = cash - shopList[itemSelected].price;
                    spaceKeyDown = false;

                    purchaseComplete = true;
                }
                if (escKeyDown == true)
                {
                    currentScreen = "mart";
                    escKeyDown = false;
                }
            }

            #endregion

            #region fightScreen

            if (currentScreen == "fightScreen")
            {
                BackgroundImage = Properties.Resources.fightBackround;

                if (running == true)
                {
                    runningCounter++;
                }
                if (runningCounter == 100)
                {
                    running = false;
                    runningCounter = 0;
                    currentScreen = "game";
                    inGameyn = false;
                }               
                    
                
                if (showAbilities == false && playerTurn == true)
                {
                    if (wKeyDown == true)
                    {
                        if (fightSelected == "items")
                        {
                            fightSelected = "fight";
                        }
                        if (fightSelected == "run")
                        {
                            fightSelected = "pkmn";
                        }
                        wKeyDown = false;
                    }
                    if (sKeyDown == true)
                    {
                        if (fightSelected == "fight")
                        {
                            fightSelected = "items";
                        }
                        if (fightSelected == "pkmn")
                        {
                            fightSelected = "run";
                        }
                        sKeyDown = false;
                    }
                    if (aKeyDown == true)
                    {
                        if (fightSelected == "pkmn")
                        {
                            fightSelected = "fight";
                        }
                        if (fightSelected == "run")
                        {
                            fightSelected = "items";
                        }
                        aKeyDown = false;
                    }
                    if (dKeyDown == true)
                    {
                        if (fightSelected == "fight")
                        {
                            fightSelected = "pkmn";
                        }
                        if (fightSelected == "items")
                        {
                            fightSelected = "run";
                        }
                        dKeyDown = false;
                    }
                    if (spaceKeyDown == true)
                    {
                        
                        if (fightSelected == "run")
                        {
                            running = true;
                            enemyPokémonList.Clear();
                            inFight = false;
                        }
                        if (fightSelected == "items")
                        {
                            currentScreen = "itemsScreen";
                            BackgroundImage = null;                           
                        }
                        if (fightSelected == "pkmn")
                        {
                            currentScreen = "pokémonScreen";
                            pokémonScreenString = "use";
                            BackgroundImage = null;
                        }
                        if (fightSelected == "fight")
                        {
                            showAbilities = true;
                            attackSelected = pokémonList[0].ability1;
                        }

                        spaceKeyDown = false;
                    }
                }
                if (pokémonList.Count() != 0)
                {
                    //abilities
                    if (showAbilities == true && playerTurn == true)
                    {
                        if (wKeyDown == true)
                        {
                            if (attackSelected == pokémonList[0].ability3)
                            {
                                if (pokémonList[0].ability1 != "--")
                                {
                                    attackSelected = pokémonList[0].ability1;
                                }
                            }
                            if (attackSelected == pokémonList[0].ability4)
                            {
                                if (pokémonList[0].ability2 != "--")
                                {
                                    attackSelected = pokémonList[0].ability2;
                                }
                            }
                            wKeyDown = false;
                        }
                        if (sKeyDown == true)
                        {
                            if (attackSelected == pokémonList[0].ability1)
                            {
                                if (pokémonList[0].ability3 != "--")
                                {
                                    attackSelected = pokémonList[0].ability3;
                                }
                            }
                            if (attackSelected == pokémonList[0].ability2)
                            {
                                if (pokémonList[0].ability4 != "--")
                                {
                                    attackSelected = pokémonList[0].ability4;
                                }
                            }
                            sKeyDown = false;
                        }
                        if (aKeyDown == true)
                        {
                            if (attackSelected == pokémonList[0].ability2)
                            {
                                if (pokémonList[0].ability1 != "--")
                                {
                                    attackSelected = pokémonList[0].ability1;
                                }
                            }
                            if (attackSelected == pokémonList[0].ability4)
                            {
                                if (pokémonList[0].ability3 != "--")
                                {
                                    attackSelected = pokémonList[0].ability3;
                                }
                            }
                            aKeyDown = false;
                        }
                        if (dKeyDown == true)
                        {
                            if (attackSelected == pokémonList[0].ability1)
                            {
                                if (pokémonList[0].ability2 != "--")
                                {
                                    attackSelected = pokémonList[0].ability2;
                                }
                            }
                            if (attackSelected == pokémonList[0].ability3)
                            {
                                if (pokémonList[0].ability4 != "--")
                                {
                                    attackSelected = pokémonList[0].ability4;
                                }
                            }
                            dKeyDown = false;

                        }

                        if (spaceKeyDown == true && msgShowing == false && pokémonList[0].health > 0)
                        {
                            if (attackSelected == "tackle")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (tackleDamage + (tackleScaling * pokémonList[0].level));
                                enemyUsed = "tackle";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (attackSelected == "thundershock")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (thundershockDamage + (thundershockScaling * pokémonList[0].level));
                                enemyUsed = "thundershock";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (attackSelected == "bugbite")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (bugbiteDamage + (bugbiteScaling * pokémonList[0].level));
                                enemyUsed = "bugbite";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (attackSelected == "bodyslam")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (bodyslamDamage + (pokémonList[0].health / 10));
                                enemyUsed = "bugbite";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "gust")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (gustDamage + (gustScaling * pokémonList[0].level));
                                enemyUsed = "gust";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }

                            if (enemyUsed == "rockthrow")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (rockthrowDamage + (rockthrowScaling * pokémonList[0].level));
                                enemyUsed = "rockthrow";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "flail")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (flailDamage + (flailScaling * pokémonList[0].level));
                                enemyUsed = "flail";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "lowkick")
                            {
                                enemyPokémonList[0].health = enemyPokémonList[0].health - (lowkickDamage + (lowkickScaling * pokémonList[0].level));
                                enemyUsed = "lowkick";

                                Message(pokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            spaceKeyDown = false;
                            playerTurn = false;
                        }

                        if (escKeyDown == true)
                        {
                            showAbilities = false;
                            escKeyDown = false;
                        }
                    }
                }

                if (pokémonList.Count() != 0)
                {
                    if (playerTurn == false && msgShowing == false)
                    {
                        randomNumber = randNum.Next(1, 1001);

                        if (randomNumber <= 250)
                        {
                            enemyUsed = enemyPokémonList[0].ability1;
                        }
                        if (randomNumber >= 251)
                        {                            
                            enemyUsed = enemyPokémonList[0].ability2;                             
                        }
                        if (randomNumber <= 501)
                        {
                            enemyUsed = enemyPokémonList[0].ability3;
                        }
                        if (randomNumber >= 751)
                        {
                            enemyUsed = enemyPokémonList[0].ability4;
                        }
                        if (pokémonList.Count() != 0)
                        {
                            if (enemyUsed == "tackle")
                            {
                                pokémonList[0].health = pokémonList[0].health - (tackleDamage + (tackleScaling * enemyPokémonList[0].level));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "poisonstrike")
                            {
                                pokémonList[0].health = pokémonList[0].health - (poisonstrikeDamage + (poisonstrikeScaling * enemyPokémonList[0].level));

                                if (randomNumber % 10 == 1)
                                {
                                    pokémonList[0].poisoned = true;
                                    Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!" + "\n" + pokémonList[0].name + "has been poisoned!");
                                    msgShowing = true;
                                }
                                else
                                {
                                    Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                    msgShowing = true;
                                }
                            }
                            if (enemyUsed == "gust")
                            {
                                pokémonList[0].health = pokémonList[0].health - (gustDamage + (gustScaling * enemyPokémonList[0].level));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "bodyslam")
                            {
                                pokémonList[0].health = pokémonList[0].health - (bodyslamDamage + (enemyPokémonList[0].health / 10));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "bugbite")
                            {
                                pokémonList[0].health = pokémonList[0].health - (bugbiteDamage + (bugbiteScaling * enemyPokémonList[0].level));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "rockthrow")
                            {
                                pokémonList[0].health = pokémonList[0].health - (rockthrowDamage + (rockthrowScaling * enemyPokémonList[0].level));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "flail")
                            {
                                pokémonList[0].health = pokémonList[0].health - (flailDamage + (flailScaling * enemyPokémonList[0].level));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                            if (enemyUsed == "lowkick")
                            {
                                pokémonList[0].health = pokémonList[0].health - (lowkickDamage + (lowkickScaling * enemyPokémonList[0].level));
                                Message("Enemy " + enemyPokémonList[0].name + " used " + enemyUsed + "!");
                                msgShowing = true;
                            }
                        }
                        playerTurn = true;
                    }
                }
                if (enemyPokémonList.Count() != 0)
                {
                    if (enemyPokémonList[0].health <= 0)
                    {
                        Message("Enemy " + enemyPokémonList[0].name + " fainted!" + "\n" + "\n" + pokémonList[0].name + " gained " + (enemyPokémonList[0].maxHealth * enemyPokémonList[0].maxHealth) / 500 + " xp!");
                        msgShowing = true;
                        pokémonList[0].xp = pokémonList[0].xp + ((enemyPokémonList[0].maxHealth * enemyPokémonList[0].maxHealth ) / 500);
                        enemyPokémonList.RemoveAt(0);
                        playerTurn = true;
                        if (sudowoodoFighting == true)
                        {
                            sudowoodoLiving = false;
                        }                        
                    }
                }
                if (pokémonList.Count() != 0)
                {
                    if (pokémonList[0].health <= 0 && msgShowing == false)
                    {
                        if (pokémonList[1].fainted == false)
                        {
                            Message(pokémonList[0].name + " fainted!");
                            msgShowing = true;
                            pokémonList[0].fainted = true;

                            swapList.Add(pokémonList[0]);
                            pokémonList.RemoveAt(0);
                            pokémonList.Add(swapList[0]);
                            attackSelected = pokémonList[0].ability1;
                        }
                        else
                        {
                            Message("You were defeated!");
                            msgShowing = true;
                            pokémonList[0].fainted = true;

                            //treeList = savetreeList;
                            //martList = savemartList;
                            //signList = savesignList;
                            //shopList = saveshopList;
                            //grassList = savegrassList;
                            //trainerList = savetrainerList;
                            //gymTrainerList = savegymTrainerList;
                            //enemyPokémonList = saveenemyPokémonList;
                            //pokémonCenterList = savepokémonCenterList;
                            //swapList = saveswapList;
                            //bankList = savebankList;
                            //gymList = savegymList;

                            currentScreen = "game";
                            for (int i = 0; i < pokémonList.Count(); i++)
                            {
                                pokémonList[i].health = pokémonList[i].maxHealth;
                            }

                        }

                        
                        playerTurn = true;
                       
                    }
                }
                if (msgCounter == 99 && enemyPokémonList.Count() == 0)
                {
                    if (gymTrainerList.Count() != 0)
                    {
                        if (gymTrainerList[trainerNumber].name == "gymOne1")
                        {
                            gymTrainerList.Clear();
                            firstBadge = true;
                        }                        
                    }
                    if (sudowoodoFighting == true)
                    {
                        sudowoodoFighting = false;
                    }
                    if (trainerList[trainerNumber].name == "BikeMan")
                    {
                        hasBike = true;
                        Message("Take this bike I don't use it anyways...");
                        msgShowing = true;
                    }

                    cash = cash + bounty;
                    if (inGym == false)
                    {
                        currentScreen = "game";
                    }
                    else
                    {
                        if (gymNumber == 1)
                        {
                            currentScreen = "gymOneScreen";
                            BackgroundImage = Properties.Resources.waterImage;
                        }
                    }
                    
                    inGameyn = false;
                    inFight = false;
                    if (inGym == true)
                    {
                        if (gymTrainerList.Count != 0)
                        {
                            gymTrainerList.RemoveAt(trainerNumber);
                        }
                    }
                }
                if (catchingPokémon == true)
                {
                    if (catchCounter != 0)
                    {
                        catchCounter--;
                    }
                    if (spaceKeyDown == true)
                    {
                        catchStrenth++;
                        spaceKeyDown = false;
                    }
                    if (catchCounter != 0)
                    {
                        if (catchCounter <= 25 || catchCounter >= 76 && catchCounter <= 125 || catchCounter >= 176)
                        {
                            catchX--;
                        }
                        if (catchCounter >= 26 && catchCounter <= 75 || catchCounter >= 126 && catchCounter <= 175)
                        {
                            catchX++;
                        }
                    }
                    if (catchCounter == 0)
                    {
                        if (enemyPokémonList.Count() != 0)
                        {
                            if (catchStrenth > catchResistance)
                            {
                                Message("You caught the " + enemyPokémonList[0].name + "!");
                                msgShowing = true;

                                pokémonList.Add(enemyPokémonList[0]);
                                enemyPokémonList.Clear();
                                catchingPokémon = false;
                                catchCounter = 200;
                                itemList.RemoveAt(itemSelected);
                                
                            }
                        }

                    }

                }
            }

            #endregion

            #region pokémonCenterScreen

            if (currentScreen == "pokémonCenterScreen")
            {
                 BackgroundImage = Properties.Resources.pokémonCenterBackground;
                
                    if (direction == "null")
                    {
                        if (aKeyDown == true && playerBuildX != 0)
                        {
                            direction = "Left";
                            drawDirection = "Left";
                            directionTicks = 10;
                        }
                        if (sKeyDown == true && playerBuildY != 540)
                        {
                            direction = "Down";
                            drawDirection = "Down";
                            directionTicks = 10;
                        }
                        if (wKeyDown == true && playerBuildY != 0)
                        {
                            direction = "Up";
                            drawDirection = "Up";
                            directionTicks = 10;
                        }
                        if (dKeyDown == true && playerBuildX != 540)
                        {
                            direction = "Right";
                            drawDirection = "Right";
                            directionTicks = 10;
                        }
                    }

                    if (directionTicks == 0)
                    {
                        direction = "null";
                    }
                    if (directionTicks > 0 && direction != "null")
                    {
                        directionTicks--;

                        if (direction == "Left")
                        {
                            int L = 3;

                            playerBuildX = playerBuildX - L;
                        }
                        if (direction == "Down")
                        {
                            int L = -3;

                            playerBuildY = playerBuildY - L;
                        }
                        if (direction == "Up")
                        {
                            int L = 3;

                            playerBuildY = playerBuildY - L;

                        }
                        if (direction == "Right")
                        {
                            int L = -3;

                            playerBuildX = playerBuildX - L;
                        }
                    }
                    if (directionTicks < 3)
                    {
                        drawTicks = 1;
                    }
                    if (directionTicks > 3 && directionTicks < 6)
                    {
                        drawTicks = 2;
                    }
                    if (directionTicks == 0 || directionTicks > 6)
                    {
                        drawTicks = 0;
                    }

                    if (playerBuildY == 540 && spaceKeyDown == true)
                    {
                        currentScreen = "game";                       

                        spaceKeyDown = false; 
                    }
                    if (playerBuildY == 90 && playerBuildX == 300 && spaceKeyDown == true)
                    {
                        spaceKeyDown = false;                        
                        Message("Your tired pokémon are now full health!");
                        msgShowing = true;

                        for (int i = 0; i < pokémonList.Count(); i++)
                        {
                            pokémonList[i].health = pokémonList[i].maxHealth;
                        }
                    }
                }

            #endregion

            #region pokémonInfoScreen

            if (currentScreen == "pokémonInfoScreen")
            {
                if (spaceKeyDown == true)
                {
                    currentScreen = "pokémonScreen";
                    pokémonScreenString = "use";
                    spaceKeyDown = false;
                }
            }

            #endregion           

            #region gymOneScreen

            if (currentScreen == "gymOneScreen")
            {
                gymNumber = 1;
                inGym = true;
                for (int i = 0; i < gymTrainerList.Count(); i++)
                {
                    rightBlocked = true;
                    leftBlocked = true;
                }


                if (direction == "null" && inGameyn == false)
                {
                    if (aKeyDown == true && playerBuildX != 0)
                    {
                        if (leftBlocked == false)
                        {
                            direction = "Left";
                            drawDirection = "Left";
                            directionTicks = 10;
                        }

                        if (playerBuildY != 180)
                        {
                            direction = "Up";
                            drawDirection = "Up";
                            directionTicks = 10;
                        }
                        else
                        {
                            trainerNumber = 2;
                            inGameyn = true;
                            leftInteraction = "null";
                            Message("Hello would you like to battle?");
                            msgShowing = true;
                        }
                    }
                    if (sKeyDown == true && playerBuildY != 540)
                    {
                        direction = "Down";
                        drawDirection = "Down";
                        directionTicks = 10;
                    }
                    if (wKeyDown == true && playerBuildY != 0)
                    {
                        if (playerBuildY != 120)
                        {
                            direction = "Up";
                            drawDirection = "Up";
                            directionTicks = 10;
                        }
                        else
                        {
                            trainerNumber = 0;
                            inGameyn = true;
                            leftInteraction = "null";
                            Message("Hello would you like to battle?");
                            msgShowing = true;
                        }
                    }
                    if (dKeyDown == true && playerBuildX != 540)
                    {
                        if (rightBlocked == false)
                        {
                            direction = "Right";
                            drawDirection = "Right";
                            directionTicks = 10;
                        }
                        if (playerBuildY == 240)
                        {
                            trainerNumber = 2;
                            inGameyn = true;
                            leftInteraction = "null";
                            Message("Hello would you like to battle?");
                            msgShowing = true;
                        }
                    }
                }

                if (inGameyn == true)
                {
                    if (wKeyDown == true && ynSelected == "no")
                    {
                        ynSelected = "yes";
                        wKeyDown = false;
                    }
                    if (sKeyDown == true && ynSelected == "yes")
                    {
                        ynSelected = "no";
                        sKeyDown = false;
                    }
                    if (spaceKeyDown == true)
                    {
                        if (ynSelected == "yes")
                        {
                            enemyPokémonList.Clear();

                            //starts fight
                            currentScreen = "fightScreen";

                            showAbilities = false;
                            if (trainerList.Count() != 0 && inGym == false)
                            {
                                if (trainerList[trainerNumber].name == "Jay")
                                {
                                    Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 2, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 2, false, 1000, false);
                                    enemyPokémonList.Add(p);

                                    Pokémon p2 = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "tackle", "tackle", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 1, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 1, false, 700, false);
                                    enemyPokémonList.Add(p2);

                                    bounty = trainerList[trainerNumber].bounty;
                                }
                                if (trainerList[trainerNumber].name == "Allitum1")
                                {
                                    Pokémon p = new Pokémon("Geodude", geodudeDescription, pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "tackle", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 4, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 4, false, 1000, false);
                                    enemyPokémonList.Add(p);

                                    bounty = trainerList[trainerNumber].bounty;
                                }
                                if (trainerList[trainerNumber].name == "Allitum2")
                                {
                                    Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "tackle", "tackle", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 3, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 3, false, 1000, false);
                                    enemyPokémonList.Add(p);

                                    bounty = trainerList[trainerNumber].bounty;
                                }
                            }
                            if (gymTrainerList.Count() != 0)
                            {
                                if (gymTrainerList[trainerNumber].name == "gymOne1")
                                {
                                    Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "tackle", "bugbite", "tackle", "bugbite", caterpieBaseHp + caterpieHpPerLevel * 8, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 8, false, 1000, false);
                                    enemyPokémonList.Add(p);

                                    Pokémon p2 = new Pokémon("Geodude", "Geodude description", pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "bodyslam", "bodyslam", "tackle", geodudeBaseHp + geodudeHpPerLevel * 9, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 9, false, 700, false);
                                    enemyPokémonList.Add(p2);

                                    Pokémon p3 = new Pokémon("Pidgey", "Pidgey description", pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "gust", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 9, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 9, false, 1000, false);
                                    enemyPokémonList.Add(p3);


                                    bounty = trainerList[trainerNumber].bounty;
                                }

                                if (gymTrainerList[trainerNumber].name == "gymOne2")
                                {
                                    Pokémon p = new Pokémon("Squeedle", "Squeedle description", pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "bugbite", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 8, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 8, false, 1000, false);
                                    enemyPokémonList.Add(p);

                                    Pokémon p2 = new Pokémon("Geodude", "Geodude description", pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "bodyslam", "bodyslam", "tackle", geodudeBaseHp + geodudeHpPerLevel * 6, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 9, false, 700, false);
                                    enemyPokémonList.Add(p2);

                                    bounty = trainerList[trainerNumber].bounty;
                                }

                                if (gymTrainerList[trainerNumber].name == "gymOne3")
                                {
                                    Pokémon p = new Pokémon("Squeedle", "Squeedle description", pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "bugbite", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 8, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 8, false, 1000, false);
                                    enemyPokémonList.Add(p);

                                    Pokémon p2 = new Pokémon("Pidgey", "Pidgey description", pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "gust", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 9, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 9, false, 1000, false);
                                    enemyPokémonList.Add(p2);

                                    bounty = trainerList[trainerNumber].bounty;
                                }
                            }
                            inFight = true;
                            msgShowing = false;
                            msgCounter = 0;
                            showAbilities = false;
                            playerTurn = true;
                            inGameyn = false;
                        }
                        if (ynSelected == "no")
                        {
                            inGameyn = false;
                        }
                    }
                }

                if (directionTicks == 0)
                {
                    direction = "null";
                }
                if (directionTicks > 0 && direction != "null")
                {
                    directionTicks--;

                    if (direction == "Left")
                    {
                        int L = 3;

                        playerBuildX = playerBuildX - L;
                    }
                    if (direction == "Down")
                    {
                        int L = -3;

                        playerBuildY = playerBuildY - L;
                    }
                    if (direction == "Up")
                    {
                        int L = 3;

                        playerBuildY = playerBuildY - L;

                    }
                    if (direction == "Right")
                    {
                        int L = -3;

                        playerBuildX = playerBuildX - L;
                    }
                }
                if (directionTicks < 3)
                {
                    drawTicks = 1;
                }
                if (directionTicks > 3 && directionTicks < 6)
                {
                    drawTicks = 2;
                }
                if (directionTicks == 0 || directionTicks > 6)
                {
                    drawTicks = 0;
                }
                if (playerBuildY == 540 && spaceKeyDown == true)
                {
                    currentScreen = "game";
                    spaceKeyDown = false;
                }                
            }

            #endregion
            

            this.Refresh();            
            }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics formGraphics = e.Graphics;

            DoubleBuffered = true;

            #region Pens and such

            SolidBrush backroundBrush = new SolidBrush(Color.RosyBrown);
            SolidBrush backroundBrush2 = new SolidBrush(Color.NavajoWhite);


            Pen gridPen = new Pen(Color.Gray, 1);



            Pen trackPen = new Pen(Color.SaddleBrown, 100);
            Pen menuPen = new Pen(Color.Silver, 100);
            Pen menuPen2 = new Pen(Color.LightGray, 10);
            Pen menuPen3 = new Pen(Color.LightGray, 6);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen blackPenw = new Pen(Color.Black, 10);
            SolidBrush grassBrush = new SolidBrush(Color.Green);
            SolidBrush scoreBrush = new SolidBrush(Color.Gold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush brownBrush = new SolidBrush(Color.SaddleBrown);
            Font smallFont = new Font("Georgia", 8);
            Font martPromptFont = new Font("Motorwerk", 32);
            Font nameFont = new Font("Ariel", 12);
            Font descriptionFont = new Font("Ariel", 16);
            SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
            SolidBrush startBrush = new SolidBrush(Color.SaddleBrown);
            SolidBrush tower1NotBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0));
            SolidBrush startBackroundBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            SolidBrush tower3Brush = new SolidBrush(Color.FromArgb(150, 255, 0, 0));
            SolidBrush towerBrush = new SolidBrush(Color.Red);          
            SolidBrush grayBrush = new SolidBrush(Color.LightGray);
            SolidBrush hide2Brush = new SolidBrush(Color.FromArgb(189, 189, 189));
            Pen hidePen = new Pen(Color.Black, 3);
            #endregion

            #region GameScreen
            if (currentScreen == "game")
            {
                //Draws all grass
                BackColor = Color.DarkSeaGreen;     

                if (upInteraction == "sign")
                {
                    formGraphics.DrawImage(martBars, 100, 100, 60, 60);
                }

                if (downInteraction == "sign")
                {
                    formGraphics.DrawImage(martBars, 100, 100, 60, 60);
                }

                if (rightInteraction == "sign")
                {
                    formGraphics.DrawImage(martBars, 100, 100, 60, 60);
                }

                if (leftInteraction == "sign")
                {
                    formGraphics.DrawImage(martBars, 100, 100, 60, 60);
                }

                for (int i = 0; i < grassList.Count(); i++)
                {
                    formGraphics.DrawImage(grassImage, grassList[i].x, grassList[i].y, 60, 60);
                }
                //Draws all trees
                for (int i = 0; i < treeList.Count(); i++)
                {              
                    //only prints if on the screen
                    //if (Math.Abs(X - treeList[i].x) < 1000 && Math.Abs(Y - treeList[i].y) < 1000)
                    //{
                        formGraphics.DrawImage(treeImage, treeList[i].x, treeList[i].y - 10, 60, 80);
                    //}
                    
                }

                if (sudowoodoLiving == true)
                {
                    //Draws sudowoodo
                    formGraphics.DrawImage(sudowoodoMapImage, sudowoodoX, sudowoodoY, 60, 60);
                }
                //draws character
                if (drawDirection == "Up")
                {
                    formGraphics.DrawImage(upMove[drawTicks], playerX, playerY, 30, 30);
                }
                if (drawDirection == "Down")
                {
                    formGraphics.DrawImage(downMove[drawTicks], playerX, playerY, 30, 30);
                }
                if (drawDirection == "Left")
                {
                    formGraphics.DrawImage(leftMove[drawTicks], playerX, playerY, 30, 30);
                }
                if (drawDirection == "Right")
                {
                    formGraphics.DrawImage(rightMove[drawTicks], playerX, playerY, 30, 30);
                }
                if (drawDirection == "null")
                {
                    formGraphics.DrawImage(downMove[0], playerX, playerY, 30, 30);
                }


                for (int i = 0; i < trainerList.Count(); i++)
                {
                    if (trainerList[i].direction == "Up")
                    {
                        formGraphics.DrawImage(trainerImage[0], trainerList[i].x, trainerList[i].y, 30, 30);
                    }
                    if (trainerList[i].direction == "Down")
                    {
                        formGraphics.DrawImage(trainerImage[1], trainerList[i].x, trainerList[i].y, 30, 30);
                    }
                    if (trainerList[i].direction == "Left")
                    {
                        formGraphics.DrawImage(trainerImage[2], trainerList[i].x, trainerList[i].y, 30, 30);
                    }
                    if (trainerList[i].direction == "Right")
                    {
                        formGraphics.DrawImage(trainerImage[3], trainerList[i].x, trainerList[i].y, 30, 30);
                    }
                }

                //Draws all signs

                for (int i = 0; i < signList.Count(); i++)
                {
                    formGraphics.DrawImage(signImage[signList[i].imageNumber], signList[i].x, signList[i].y - 10, 30, 30);
                }

                //draws all houses
                for (int i = 0; i < houseList.Count(); i++)
                {
                    if (houseList[i].houseNumber == 0)
                    {
                        formGraphics.DrawImage(houseImage[houseList[i].houseNumber], houseList[i].x, houseList[i].y, 60, 60);
                    }
                    if (houseList[i].houseNumber == 1)
                    {
                        formGraphics.DrawImage(houseImage[houseList[i].houseNumber], houseList[i].x, houseList[i].y, 120, 60);
                    }
                }
                //Draws all marts
                for (int i = 0; i < martList.Count(); i++)
                {
                    formGraphics.DrawImage(martImage, martList[i].x, martList[i].y - 10, 60, 60);
                }
                //Draws all gyms
                for (int i = 0; i < gymList.Count(); i++)
                {
                    formGraphics.DrawImage(gymImage[gymList[i].gymNumber], gymList[i].x, gymList[i].y - 10, 270, 180);
                }

                //draws all pokémonCenters
                for (int i = 0; i < pokémonCenterList.Count(); i++)
                {
                    formGraphics.DrawImage(pokémonCenterImage, pokémonCenterList[i].x, pokémonCenterList[i].y - 5, 150, 90);
                }

                if (msgShowing == true)
                {

                    formGraphics.FillRectangle(whiteBrush, 50, 500, 500, 50);
                    formGraphics.DrawRectangle(blackPen, 50, 500, 500, 50);
                    formGraphics.DrawString(msg, nameFont, blackBrush, 60, 510);
                }

                if (inGameMenu == true)
                {
                    formGraphics.FillRectangle(whiteBrush, 480, 100, 100, 180);
                    formGraphics.DrawRectangle(blackPen, 480, 100, 100, 180);

                    formGraphics.DrawString("Items", nameFont, blackBrush, 495, 120);
                    formGraphics.DrawString("Pokémon", nameFont, blackBrush, 495, 160);
                    formGraphics.DrawString("Player", nameFont, blackBrush, 495, 200);
                    formGraphics.DrawString("Exit", nameFont, blackBrush, 495, 240);

                    if (menuSelected == "items")
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 120, 80, 20);
                    }
                    if (menuSelected == "pokémon")
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 160, 80, 20);
                    }
                    if (menuSelected == "player")
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 200, 80, 20);
                    }
                    if (menuSelected == "exit")
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 240, 80, 20);
                    }
                }

                if (inGameyn == true)
                {
                    formGraphics.FillRectangle(whiteBrush, 480, 400, 80, 80);
                    formGraphics.DrawRectangle(blackPen, 480, 400, 80, 80);

                    formGraphics.DrawString("Yes", nameFont, blackBrush, 495, 420);
                    formGraphics.DrawString("No", nameFont, blackBrush, 495, 440);

                    if (ynSelected == "yes")
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 420, 40, 20);
                    }
                    else
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 440, 40, 20);
                    }
                }
            }
            #endregion

            #region martScreen
            if (currentScreen == "mart")
            {
                //BackgroundImage = Properties.Resources.martBackround;

                //draws mat
                formGraphics.DrawImage(martMat, 0, 480, this.Width, 120);                

                //draws character
                if (drawDirection == "Up")
                {
                    formGraphics.DrawImage(upMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "Down")
                {
                    formGraphics.DrawImage(downMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "Left")
                {
                    formGraphics.DrawImage(leftMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "Right")
                {
                    formGraphics.DrawImage(rightMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "null")
                {
                    formGraphics.DrawImage(downMove[0], playerBuildX, playerBuildY, 50, 50);
                }

                //draws bars
                formGraphics.DrawImage(martBars, 0, 540, this.Width, 60);

                if (playerBuildY == 540)
                {
                    formGraphics.DrawString("Press [space] To shop", martPromptFont, redBrush, 100, 100);
                }
                if (playerBuildY == 0)
                {
                    formGraphics.DrawString("Press [space] To leave", martPromptFont, redBrush, 100, 100);
                }
            }
            #endregion        

            #region itemsScreen

            if (currentScreen == "itemsScreen")
            {
                BackColor = Color.LightGray;


                itemx = 50;
                itemy = 50;
                for (int i = 0; i < itemList.Count(); i++)
                {
                    itemList[i].x = itemx;
                    itemList[i].y = itemy;

                    formGraphics.DrawImage(itemList[i].itemImage[itemList[i].imageNumber], itemList[i].x, itemList[i].y, 50, 50);     
                    formGraphics.DrawString(itemList[i].name, nameFont, blackBrush, itemx, itemy - 30);

                    formGraphics.DrawRectangle(blackPen, itemList[itemSelected].x - 5, itemList[itemSelected].y - 5, 60, 60);

                    itemx = itemx + 100;
                    if (itemx == 550)
                    {
                        itemy = itemy + 100;
                        itemx = 50;
                    }
                }
                if (itemList.Count() != 0)
                {
                    formGraphics.DrawString(itemList[itemSelected].description, descriptionFont, blackBrush, 100, 500);
                }
                formGraphics.DrawString("Press [escape] to return to the game", descriptionFont, blackBrush, 100, 550);

                if (msgShowing == true)
                {
                    formGraphics.FillRectangle(whiteBrush, 100, 400, 400, 50);
                    formGraphics.DrawRectangle(blackPen, 100, 400, 400, 50);
                    formGraphics.DrawString(msg, nameFont, blackBrush, 110, 410);
                }
            }
            #endregion

            #region pokémonScreen

            if (currentScreen == "pokémonScreen")
            {
                BackColor = Color.LightGray;


                itemx = 50;
                itemy = 50;
                for (int i = 0; i < pokémonList.Count(); i++)
                {
                    pokémonList[i].x = itemx;
                    pokémonList[i].y = itemy;

                    formGraphics.DrawImage(pokémonList[i].pokémonImage[pokémonList[i].imageNumber], pokémonList[i].x, pokémonList[i].y, 50, 50);
                    formGraphics.DrawString(pokémonList[i].name, nameFont, blackBrush, itemx, itemy - 30);

                    formGraphics.DrawRectangle(blackPen, pokémonList[pokémonSelected].x - 5, pokémonList[pokémonSelected].y - 5, 60, 60);

                    itemy = itemy + 100;
                    if (itemx == 550)
                    {
                        itemy = itemy + 100;
                        itemx = 50;
                    }
                }

                formGraphics.DrawString(pokémonList[pokémonSelected].description, descriptionFont, blackBrush, 100, 500);
                if (itemList.Count() != 0)
                {
                    if (itemList[itemSelected].name != "Exit")
                    {
                        formGraphics.DrawImage(itemList[itemSelected].itemImage[itemList[itemSelected].imageNumber], 500, 500, 50, 50);
                    }
                }
                if (msgShowing == true)
                {
                    formGraphics.FillRectangle(whiteBrush, 100, 400, 400, 50);
                    formGraphics.DrawRectangle(blackPen, 100, 400, 400, 50);
                    formGraphics.DrawString(msg, nameFont, blackBrush, 110, 410);
                }
                if (pokémonScreenMenu == true)
                {
                    if (inFight == true)
                    {
                        formGraphics.FillRectangle(whiteBrush, 250, 200, 200, 150);
                        formGraphics.DrawRectangle(blackPen, 250, 200, 200, 150);

                        formGraphics.DrawString("fight", nameFont, blackBrush, 270, 215);
                    }
                    else
                    {
                        formGraphics.FillRectangle(whiteBrush, 250, 250, 200, 100);
                        formGraphics.DrawRectangle(blackPen, 250, 250, 200, 100);
                    }
                    if (itemList.Count() != 0)
                    {
                        if (itemList[itemSelected].name != "Boat")
                        {
                            formGraphics.DrawString("use " + itemList[itemSelected].name, nameFont, blackBrush, 270, 265);
                        }
                    }
                    else
                    {
                        formGraphics.DrawString("You cannot use a Boat", nameFont, blackBrush, 270, 265);
                    }

                    formGraphics.DrawString("info for " + pokémonList[pokémonSelected].name, nameFont, blackBrush, 270, 310);
                    if (pokémonScreenString == "fight")
                    {
                        formGraphics.DrawRectangle(blackPen, 255, 205, 180, 45);
                    }
                    if (pokémonScreenString == "use")
                    {
                        formGraphics.DrawRectangle(blackPen, 255, 255, 180, 45);
                    }
                    if (pokémonScreenString == "info")
                    {
                        formGraphics.DrawRectangle(blackPen, 255, 300, 180, 45);
                    }
                }
                if (inFight == false)
                {
                    formGraphics.DrawString("Press [escape] to return to the game", descriptionFont, blackBrush, 100, 550);
                }
                else
                {
                    formGraphics.DrawString("Press [escape] to return to the fight", descriptionFont, blackBrush, 100, 550);
                }
            }
            #endregion

            #region playerScreen

            if (currentScreen == "playerScreen")
            {
                BackColor = Color.LightGray;

                formGraphics.DrawRectangle(blackPen, 50, 50, 500, 500);

                formGraphics.DrawString("Name: " + playerName, descriptionFont, blackBrush, 100, 100);

                formGraphics.DrawString("Cash: " + cash, descriptionFont, blackBrush, 100, 150);

                formGraphics.DrawString("Press [space] to exit" , descriptionFont, blackBrush, 100, 500);
            }
            
            #endregion

            #region shopScreen

            if (currentScreen == "shopScreen")
            {
                BackColor = Color.LightGray;
                BackgroundImage = null;

                itemx = 50;
                itemy = 50;
                for (int i = 0; i < shopList.Count(); i++)
                {
                    shopList[i].x = itemx;
                    shopList[i].y = itemy;

                    formGraphics.DrawImage(shopList[i].itemImage[shopList[i].imageNumber], shopList[i].x, shopList[i].y, 50, 50);
                    formGraphics.DrawString(shopList[i].name, nameFont, blackBrush, itemx, itemy - 30);

                    formGraphics.DrawRectangle(blackPen, shopList[itemSelected].x - 5, shopList[itemSelected].y - 5, 60, 60);

                    itemy = itemy + 100;                    
                }
                if (shopList[itemSelected].price != 0)
                {
                    formGraphics.DrawString(shopList[itemSelected].description + "           Cost: " + shopList[itemSelected].price, descriptionFont, blackBrush, 100, 500);
                }
                else
                {
                    formGraphics.DrawString(shopList[itemSelected].description, descriptionFont, blackBrush, 100, 500);
                }

                if (purchaseComplete == true)
                {
                    formGraphics.DrawRectangle(blackPen, 200, 220, 240, 80);
                    formGraphics.FillRectangle(whiteBrush, 200, 220, 240, 80);
                    formGraphics.DrawString("Purchase Complete!", descriptionFont, blackBrush, 210, 250);                    
                    Message("Purchase Complete");
                    msgShowing = true;    
                }
              
                formGraphics.DrawString("Press [escape] to return to the mart", descriptionFont, blackBrush, 100, 550);
                
            }
            #endregion

            #region fightScreen

            if (currentScreen == "fightScreen")
            {
                formGraphics.DrawString("Fight", descriptionFont, blackBrush, 440, 480);
                formGraphics.DrawString("Pkmn", descriptionFont, blackBrush, 500, 480);
                formGraphics.DrawString("Items", descriptionFont, blackBrush, 440, 520);
                formGraphics.DrawString("Run", descriptionFont, blackBrush, 500, 520);
                
                
                    formGraphics.FillRectangle(whiteBrush, 350, 350, 200, 80);
                    formGraphics.FillRectangle(greenBrush, 440, 380, hpPercent, 5);
                    formGraphics.FillRectangle(blueBrush, 440, 400, xpPercent, 5);

                    formGraphics.DrawRectangle(blackPen, 440, 380, 100, 5);
                    formGraphics.DrawRectangle(blackPen, 440, 400, 100, 5);
                    if (pokémonList.Count() != 0)
                    {
                        formGraphics.DrawString(pokémonList[0].name, smallFont, blackBrush, 440, 360);

                        formGraphics.DrawString("HP: " + pokémonList[0].health + "/" + pokémonList[0].maxHealth + "\n" + "\n" + "xp: " + "\n" + "lvl " + pokémonList[0].level, smallFont, blackBrush, 380, 375);
                    }        
                    for (int i = 0; i < pokémonList.Count(); i++)
                    {
                        formGraphics.DrawImage(pokéball, 350 + (i * 10), 360, 10, 10);
                    }
                
                    formGraphics.FillRectangle(whiteBrush, 50, 50, 200, 80);
                    formGraphics.FillRectangle(greenBrush, 140, 80, enemyHpPercent, 5);
                    formGraphics.DrawRectangle(blackPen, 140, 80, 100, 5);
               
               
                
                    formGraphics.FillRectangle(whiteBrush, 350, 350, 200, 80);
                    formGraphics.FillRectangle(greenBrush, 440, 380, hpPercent, 5);
                    if (xpPercent > 100)
                    {
                        formGraphics.FillRectangle(blueBrush, 440, 400, 100, 5);
                    }
                    else
                    {
                        formGraphics.FillRectangle(blueBrush, 440, 400, xpPercent, 5);
                    }
                    formGraphics.DrawRectangle(blackPen, 440, 380, 100, 5);
                    formGraphics.DrawRectangle(blackPen, 440, 400, 100, 5);
                    if (pokémonList.Count() != 0)
                    {
                        formGraphics.DrawString(pokémonList[0].name, smallFont, blackBrush, 440, 360);

                        formGraphics.DrawString("HP: " + pokémonList[0].health + "/" + pokémonList[0].maxHealth + "\n" + "\n" + "xp: " + "\n" + "lvl " + pokémonList[0].level, smallFont, blackBrush, 350, 375);
                    }
                    for (int i = 0; i < pokémonList.Count(); i++)
                    {
                        formGraphics.DrawImage(pokéball, 350 + (i * 10), 360, 10, 10);
                    }

                    formGraphics.FillRectangle(whiteBrush, 50, 50, 200, 80);
                    formGraphics.FillRectangle(greenBrush, 140, 80, enemyHpPercent, 5);
                    formGraphics.DrawRectangle(blackPen, 140, 80, 100, 5);
                if (enemyPokémonList.Count() != 0)
                {
                    formGraphics.DrawString(enemyPokémonList[0].name, smallFont, blackBrush, 140, 60);

                    formGraphics.DrawString("HP: " + enemyPokémonList[0].health + "/" + enemyPokémonList[0].maxHealth + "\n" + "\n" + "lvl " + enemyPokémonList[0].level, smallFont, blackBrush, 60, 75);
                }
                if (playerTurn == true && msgShowing == false)
                {
                    if (showAbilities == false)
                    {
                        if (fightSelected == "fight")
                        {
                            formGraphics.DrawRectangle(blackPen, 440, 480, 60, 40);
                        }
                        if (fightSelected == "pkmn")
                        {
                            formGraphics.DrawRectangle(blackPen, 500, 480, 60, 40);
                        }
                        if (fightSelected == "items")
                        {
                            formGraphics.DrawRectangle(blackPen, 440, 520, 60, 40);
                        }
                        if (fightSelected == "run")
                        {
                            formGraphics.DrawRectangle(blackPen, 500, 520, 60, 40);
                        }
                    }
                    if (pokémonList.Count() != 0)
                    {
                        if (showAbilities == true)
                        {
                            if (attackSelected == pokémonList[0].ability1)
                            {
                                formGraphics.DrawRectangle(blackPen, 50, 480, 175, 30);
                            }
                            if (attackSelected == pokémonList[0].ability2)
                            {
                                formGraphics.DrawRectangle(blackPen, 250, 480, 175, 30);
                            }
                            if (attackSelected == pokémonList[0].ability3)
                            {
                                formGraphics.DrawRectangle(blackPen, 50, 520, 175, 30);
                            }
                            if (attackSelected == pokémonList[0].ability4)
                            {
                                formGraphics.DrawRectangle(blackPen, 250, 520, 175, 30);
                            }

                            formGraphics.DrawString(pokémonList[0].ability1, descriptionFont, blackBrush, 50, 480);
                            formGraphics.DrawString(pokémonList[0].ability2, descriptionFont, blackBrush, 250, 480);

                            formGraphics.DrawString(pokémonList[0].ability3, descriptionFont, blackBrush, 50, 520);
                            formGraphics.DrawString(pokémonList[0].ability4, descriptionFont, blackBrush, 250, 520);

                        }
                    }
                }
                if (pokémonList.Count() != 0)
                {
                    //draws your pokémon
                    formGraphics.DrawImage(pokémonList[0].pokémonImageBack[pokémonList[0].imageNumber], 50, 295, 150, 150);
                }
                if (msgShowing == true)
                {
                    formGraphics.DrawString(msg, descriptionFont, blackBrush, 50, 480);
                }
                
                //draws enemy pokémon
                if (enemyPokémonList.Count() != 0)
                {
                    if (catchingPokémon == false)
                    {
                        formGraphics.DrawImage(enemyPokémonList[0].pokémonImage[enemyPokémonList[0].imageNumber], 425, 125, 100, 150);
                    }
                    else
                    {
                        if (itemList[itemSelected].name == "Pokéball")
                        {
                            formGraphics.DrawImage(itemImage[1], catchX, 250, 50, 50);
                        }
                        if (itemList[itemSelected].name == "Greatball")
                        {
                            formGraphics.DrawImage(itemImage[3], catchX, 250, 50, 50);
                        }
                    }
                }

                for (int i = 0; i < enemyPokémonList.Count(); i++)
                {
                    formGraphics.DrawImage(pokéball, 50 + (i * 10), 60, 10, 10);
                }
                if (running == true)
                {
                    formGraphics.DrawString("You got away safely", descriptionFont, blackBrush, 200, 480);
                }
                if (showAbilities == true)
                {
                      
                }
            }

            #endregion

            #region pokémonCenterScreen

            if (currentScreen == "pokémonCenterScreen")
            {
                
                formGraphics.FillRectangle(brownBrush, 300, 90, 50, 50);
                formGraphics.DrawRectangle(blackPen, 300, 90, 50, 50);
                formGraphics.DrawImage(pokéball, 300, 90, 50, 50);

                if (drawDirection == "Up")
                {
                    formGraphics.DrawImage(upMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "Down")
                {
                    formGraphics.DrawImage(downMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "Left")
                {
                    formGraphics.DrawImage(leftMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (drawDirection == "Right")
                {
                    formGraphics.DrawImage(rightMove[drawTicks], playerBuildX, playerBuildY, 50, 50);
                }
                if (playerBuildY == 90 && playerBuildX == 300 && msgShowing == false)
                {                    
                    formGraphics.FillRectangle(whiteBrush, 150, 390, 350, 50);
                    formGraphics.DrawRectangle(blackPen, 150, 390, 350, 50);
                    formGraphics.DrawString("Press [space] to heal your pokémon", descriptionFont, blackBrush, 150, 400);
                }
                if (playerBuildY == 540 && msgShowing == false)
                {
                    formGraphics.FillRectangle(whiteBrush, 150, 390, 250, 50);
                    formGraphics.DrawRectangle(blackPen, 150, 390, 250, 50);
                    formGraphics.DrawString("Press [space] to leave", descriptionFont, blackBrush, 150, 400);
                }
                if (msgShowing == true)
                {                    
                    formGraphics.FillRectangle(whiteBrush, 150, 390, 385, 50);
                    formGraphics.DrawRectangle(blackPen, 150, 390, 385, 50);
                    formGraphics.DrawString(msg, descriptionFont, blackBrush, 150, 400);
                }
            }


            #endregion

            #region pokémonInfoScreen

            if (currentScreen == "pokémonInfoScreen")
            {
                formGraphics.DrawString(pokémonList[pokémonSelected].name + "\n" + "\n" + pokémonList[pokémonSelected].description, descriptionFont, blackBrush, 100, 50);

                formGraphics.DrawString("hp: " + pokémonList[pokémonSelected].health + "/" + pokémonList[pokémonSelected].maxHealth, descriptionFont, blackBrush, 100, 150);

                formGraphics.DrawString("xp: " + pokémonList[pokémonSelected].xp + "/" + pokémonList[pokémonSelected].level * (pokémonList[pokémonSelected].level + 100), descriptionFont, blackBrush, 100, 200);

                formGraphics.DrawString("Level: " + pokémonList[pokémonSelected].level, descriptionFont, blackBrush, 100, 250);

                formGraphics.DrawImage(pokémonList[pokémonSelected].pokémonImage[pokémonList[pokémonSelected].imageNumber], 250, 300, 200, 200);

                formGraphics.DrawString("press [space] to return", descriptionFont, blackBrush, 100, 550);
            }

            #endregion

            #region gymOneScreen
            
            if (currentScreen == "gymOneScreen")
            {
                //draws character
                if (drawDirection == "Up")
                {
                    formGraphics.DrawImage(upMove[drawTicks], playerBuildX, playerBuildY, 60, 60);
                }
                if (drawDirection == "Down")
                {
                    formGraphics.DrawImage(downMove[drawTicks], playerBuildX, playerBuildY, 60, 60);
                }
                if (drawDirection == "Left")
                {
                    formGraphics.DrawImage(leftMove[drawTicks], playerBuildX, playerBuildY, 60, 60);
                }
                if (drawDirection == "Right")
                {
                    formGraphics.DrawImage(rightMove[drawTicks], playerBuildX, playerBuildY, 60, 60);
                }
                if (drawDirection == "null")
                {
                    formGraphics.DrawImage(downMove[0], playerBuildX, playerBuildY, 60, 60);
                }
                
                for (int i = 0; i < gymTrainerList.Count(); i++)
                {
                    if (gymTrainerList[i].direction == "Up")
                    {
                        formGraphics.DrawImage(trainerImage[0], gymTrainerList[i].x, gymTrainerList[i].y - 10, 60, 60);
                    }
                    if (gymTrainerList[i].direction == "Down")
                    {
                        formGraphics.DrawImage(trainerImage[1], gymTrainerList[i].x, gymTrainerList[i].y - 10, 60, 60);
                    }
                    if (gymTrainerList[i].direction == "Left")
                    {
                        formGraphics.DrawImage(trainerImage[2], gymTrainerList[i].x, gymTrainerList[i].y - 10, 60, 60);
                    }
                    if (gymTrainerList[i].direction == "Right")
                    {
                        formGraphics.DrawImage(trainerImage[3], gymTrainerList[i].x, gymTrainerList[i].y - 10, 60, 60);
                    }
                }

                if (inGameyn == true)
                {
                    formGraphics.FillRectangle(whiteBrush, 480, 400, 80, 80);
                    formGraphics.DrawRectangle(blackPen, 480, 400, 80, 80);

                    formGraphics.DrawString("Yes", nameFont, blackBrush, 495, 420);
                    formGraphics.DrawString("No", nameFont, blackBrush, 495, 440);

                    if (ynSelected == "yes")
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 420, 40, 20);
                    }
                    else
                    {
                        formGraphics.DrawRectangle(blackPen, 495, 440, 40, 20);
                    }
                }

                if (msgShowing == true)
                {
                    formGraphics.FillRectangle(whiteBrush, 50, 500, 500, 50);
                    formGraphics.DrawRectangle(blackPen, 50, 500, 500, 50);
                    formGraphics.DrawString(msg, nameFont, blackBrush, 60, 510);
                }
                if (playerBuildY == 540)
                {
                    formGraphics.FillRectangle(whiteBrush, 50, 500, 500, 50);
                    formGraphics.DrawRectangle(blackPen, 50, 500, 500, 50);
                    formGraphics.DrawString("press [space] to leave the gym", nameFont, blackBrush, 60, 510);
                }
            }

            #endregion

            //for debugging
            //formGraphics.DrawString(X + "   " + Y + "   " + currentScreen + "  " + usingBike + "  " + catchResistance + "  " + playerBuildX + "  " + playerBuildY, descriptionFont, blackBrush, 0, 0);
        }

        private void ScreenChange()
        {
            if (upInteraction != "null")
            {
                if (upInteraction == "martEntrance")
                {
                    currentScreen = "mart";
                    drawDirection = "Down";
                    BackgroundImage = Properties.Resources.martBackround;
                    playerBuildY = 0;
                    playerBuildX = 300;
                }
                if (upInteraction == "pokémonCenterEntrance")
                {
                    currentScreen = "pokémonCenterScreen";
                    drawDirection = "Up";
                    BackgroundImage = Properties.Resources.pokémonCenterBackground;
                    playerBuildY = 540;
                    playerBuildX = 300;
                }
                if (upInteraction == "bankEntrance")
                {
                    currentScreen = "bankScreen";
                    drawDirection = "Up";                    
                    playerBuildY = 540;
                    playerBuildX = 300;

                }
                if (upInteraction == "gymOneEnterance")
                {
                    BackgroundImage = Properties.Resources.waterImage;
                    currentScreen = "gymOneScreen";
                    drawDirection = "Up";
                    playerBuildY = 540;
                    playerBuildX = 300;

                    for (int i = 0; i < 1; i++)
                    {
                        Trainer t = new Trainer("gymOne1", trainerImage, 300, 60, 1, "Down", 147);
                        gymTrainerList.Add(t);
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Trainer t = new Trainer("gymOne2", trainerImage, 240, 180, 1, "Right", 39);
                        gymTrainerList.Add(t);
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Trainer t = new Trainer("gymOne3", trainerImage, 360, 240, 1, "Left", 43);
                        gymTrainerList.Add(t);
                    }

                }
            }
            if (downInteraction != "null")
            {

            }
            if (leftInteraction != "null")
            {

            }
            if (rightInteraction != "null")
            {

            }
        }

        private void EnemyFound()
        
        {
            if (inGrass == true)
            {
                randomNumber = randNum.Next(1, 1001);

                if (randomNumber <= 60)
                {
                    for (int i = 0; i < grassList.Count(); i++)
                    {
                        if (grassList[i].x >= 270 && grassList[i].x <= 300 && grassList[i].y >= 270 && grassList[i].y <= 300)
                        {
                            if (grassList[i].level == 1)
                            {
                                showAbilities = false;
                              
                                if (randomNumber <= 25)
                                {
                                    Pokémon p = new Pokémon("Geodude", "Geodude description", pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "tackle", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 2, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 2, false, 700, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 26 && randomNumber <= 40)
                                {
                                    Pokémon p = new Pokémon("Squeedle", "Squeedle description", pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 3, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 3, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 41 && randomNumber <= 60)
                                {
                                    Pokémon p = new Pokémon("Pidgey", "Pidgey description", pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "tackle", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 2, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 2, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                            }
                            if (grassList[i].level == 2)
                            {
                                showAbilities = false;
                                if (randomNumber <= 10)
                                {
                                    Pokémon p = new Pokémon("Hoothoot", hoothootDescription, pokémonImage, pokémonImageBack, 6, 0, 0, "scratch", "scratch", "tackle", "tackle", hoothootBaseHp + pidgeyHpPerLevel * 5, 10, hoothootBaseHp, hoothootHpPerLevel, 50, 5, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 11 && randomNumber <= 25)
                                {
                                    Pokémon p = new Pokémon("Geodude", geodudeDescription, pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "tackle", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 6, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 6, false, 700, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 26 && randomNumber <= 40)
                                {
                                    Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 4, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 4, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 41 && randomNumber <= 60)
                                {
                                    Pokémon p = new Pokémon("Pidgey", pidgeyDescription, pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "tackle", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 4, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 4, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }                                
                            }
                            if (grassList[i].level == 3)
                            {
                                showAbilities = false;
                                if (randomNumber <= 10)
                               {
                                    Pokémon p = new Pokémon("Hoothoot", hoothootDescription, pokémonImage, pokémonImageBack, 6, 0, 0, "scratch", "scratch", "tackle", "tackle", hoothootBaseHp + pidgeyHpPerLevel * 8, 10, hoothootBaseHp, hoothootHpPerLevel, 50, 8, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 11 && randomNumber <= 20)
                                {
                                    Pokémon p = new Pokémon("Geodude", geodudeDescription, pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "bodyslam", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 9, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 9, false, 700, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 21 && randomNumber <= 30)
                                {
                                    Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 10, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 10, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 31 && randomNumber <= 40)
                                {
                                    Pokémon p = new Pokémon("Pidgey", pidgeyDescription, pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "tackle", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 4, 11, pidgeyBaseHp, pidgeyHpPerLevel, 50, 11, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 41 && randomNumber <= 50)
                                {
                                    Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "bugbite", "bugbite", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 9, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 9, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 51 && randomNumber <= 60)
                                {
                                    Pokémon p = new Pokémon("Spinarak", spinarakDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "bugbite", "bugbite", "tackle", "tackle", spinarakBaseHp + spinarakHpPerLevel * 10, 10, spinarakBaseHp, spinarakHpPerLevel, 50, 10, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                            }
                            if (grassList[i].level == 4)
                            {
                                showAbilities = false;
                                if (randomNumber <= 10)
                                {
                                    Pokémon p = new Pokémon("Hoothoot", hoothootDescription, pokémonImage, pokémonImageBack, 6, 0, 0, "scratch", "scratch", "tackle", "tackle", hoothootBaseHp + pidgeyHpPerLevel * 10, 10, hoothootBaseHp, hoothootHpPerLevel, 50, 10, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 11 && randomNumber <= 20)
                                {
                                    Pokémon p = new Pokémon("Geodude", geodudeDescription, pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "bodyslam", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 11, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 11, false, 700, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 21 && randomNumber <= 30)
                                {
                                    Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 12, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 12, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 31 && randomNumber <= 40)
                                {
                                    Pokémon p = new Pokémon("Pidgey", pidgeyDescription, pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "tackle", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 4, 11, pidgeyBaseHp, pidgeyHpPerLevel, 50, 11, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 41 && randomNumber <= 50)
                                {
                                    Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "bugbite", "bugbite", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 10, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 10, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 51 && randomNumber <= 60)
                                {
                                    Pokémon p = new Pokémon("Spinarak", spinarakDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "bugbite", "bugbite", "tackle", "tackle", spinarakBaseHp + spinarakHpPerLevel * 11, 10, spinarakBaseHp, spinarakHpPerLevel, 50, 11, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                            }
                            if (grassList[i].level == 5)
                            {
                                showAbilities = false;
                                if (randomNumber <= 10)
                                {
                                    Pokémon p = new Pokémon("Hoothoot", hoothootDescription, pokémonImage, pokémonImageBack, 6, 0, 0, "scratch", "scratch", "tackle", "tackle", hoothootBaseHp + pidgeyHpPerLevel * 12, 10, hoothootBaseHp, hoothootHpPerLevel, 50, 12, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 11 && randomNumber <= 20)
                                {
                                   Pokémon p = new Pokémon("Geodude", geodudeDescription, pokémonImage, pokémonImageBack, 2, 0, 0, "tackle", "bodyslam", "tackle", "tackle", geodudeBaseHp + geodudeHpPerLevel * 13, 10, geodudeBaseHp, geodudeHpPerLevel, 50, 13, false, 700, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 21 && randomNumber <= 30)
                                {
                                    Pokémon p = new Pokémon("Squeedle", squeedleDescription, pokémonImage, pokémonImageBack, 1, 0, 0, "tackle", "tackle", "tackle", "tackle", squeedleBaseHp + squeedleHpPerLevel * 13, 10, squeedleBaseHp, squeedleHpPerLevel, 50, 13, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 31 && randomNumber <= 40)
                                {
                                    Pokémon p = new Pokémon("Pidgey", pidgeyDescription, pokémonImage, pokémonImageBack, 3, 0, 0, "tackle", "gust", "tackle", "tackle", pidgeyBaseHp + pidgeyHpPerLevel * 12, 10, pidgeyBaseHp, pidgeyHpPerLevel, 50, 12, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 41 && randomNumber <= 50)
                                {
                                    Pokémon p = new Pokémon("Caterpie", caterpieDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "bugbite", "bugbite", "tackle", "tackle", caterpieBaseHp + caterpieHpPerLevel * 11, 10, caterpieBaseHp, caterpieHpPerLevel, 50, 11, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                                if (randomNumber >= 51 && randomNumber <= 60)
                                {
                                    Pokémon p = new Pokémon("Spinarak", spinarakDescription, pokémonImage, pokémonImageBack, 4, 0, 0, "bugbite", "bugbite", "tackle", "tackle", spinarakBaseHp + spinarakHpPerLevel * 11, 10, spinarakBaseHp, spinarakHpPerLevel, 50, 11, false, 1000, false);
                                    enemyPokémonList.Add(p);
                                }
                            }
                        }
                    }


                    
            currentScreen = "fightScreen";
            inFight = true;
            Message("A wild pokémon appeared!");
            msgShowing = true;
            playerTurn = true;
            fightSelected = "fight";

        }
                
        }
    }

        private void Message(string message)
        {
            msgShowing = true;
            msg = message;
        }

        private void FightStart(int n)
        {
            


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (currentScreen == "game")
            {
                if (inGameMenu == true)
                {
                    if (menuSelected == "items")
                    {
                        currentScreen = "itemsScreen";
                    }
                    if (menuSelected == "pokémon")
                    {
                        currentScreen = "pokémonScreen";
                        pokémonScreenString = "use";
                    }
                    if (menuSelected == "player")
                    {
                        currentScreen = "playerScreen";
                    }
                    if (menuSelected == "exit")
                    {

                    }
                }
            }
        }
    }
}
