using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersFor3
{
    public partial class Form1 : Form
    {
        PairOfPoints start;
        List<PairOfPoints> Points;
        List<Checker> Checkers, nextMove;
        Checker[] delete;
        Checker[] beatCheck;
        Players turn=Players.player1;
        Players deleted = (Players)3;//(Players)3;
        public Form1()
        {
            InitializeComponent();
            Points = initializePoints();
            Checkers = InitializeCheckers(Points);
            nextMove = initializeMove();
        }

        Checker findChecker(PictureBox pB)
        {
            return Checkers.Find(delegate (Checker checker) { return checker.picBox == pB; });
        }
        Checker findAbstractChecker(PictureBox pB)
        {
            return nextMove.Find(delegate (Checker checker) { return checker.picBox == pB; });
        }
        Checker findAbstractChecker(PairOfPoints pop)
        {

            if (pop == null) return null;
            Checker buf = new Checker(pop);
            return buf;
        }

       Checker findChecker()
        {
            return Checkers.Find(delegate (Checker checker) { return checker.isChecked == true; });
        }
        Checker findChecker(PairOfPoints pop)
        {
            if (pop == null) return null;
            for (int i = 0; i < Checkers.Count; i++)
            {
                if (Checkers[i].location == pop && Checkers[i].picBox.Visible == true) return Checkers[i];
      
            }
            return null;

           
           
        }
        public void setNonChecked()
        {
            foreach(Checker ch in Checkers)
            {
                ch.isChecked = false;
            }
        }
        public List<Checker> InitializeCheckers(List<PairOfPoints> points)
        {
            List<Checker> checkersList = new List<Checker>();
            for (int i = 0; i < 48; i++)
            {
                if ((i >= 0 && i <= 7) || (i >= 16 && i <= 23) || (i >= 32 && i <= 39))
                {
                    Checker buf = new Checker(points[i]);
                    switch (i)
                    {
                        case 0:
                            buf.picBox = pictureBox1; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 1:
                            buf.picBox = pictureBox2; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 2:
                            buf.picBox = pictureBox3; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 3:
                            buf.picBox = pictureBox4; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 4:
                            buf.picBox = pictureBox5; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 5:
                            buf.picBox = pictureBox6; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 6:
                            buf.picBox = pictureBox7; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;
                        case 7:
                            buf.picBox = pictureBox8; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player1; break;

                        case 16:
                            buf.picBox = pictureBox9; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 17:
                            buf.picBox = pictureBox10; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 18:
                            buf.picBox = pictureBox11; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 19:
                            buf.picBox = pictureBox12; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 20:
                            buf.picBox = pictureBox13; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 21:
                            buf.picBox = pictureBox14; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 22:
                            buf.picBox = pictureBox15; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;
                        case 23:
                            buf.picBox = pictureBox16; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player2; break;

                        case 32:
                            buf.picBox = pictureBox17; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 33:
                            buf.picBox = pictureBox18; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 34:
                            buf.picBox = pictureBox19; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 35:
                            buf.picBox = pictureBox20; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 36:
                            buf.picBox = pictureBox21; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 37:
                            buf.picBox = pictureBox22; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 38:
                            buf.picBox = pictureBox23; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                        case 39:
                            buf.picBox = pictureBox24; buf.picBox.Location = new Point(buf.location.x, buf.location.y); buf.location.engaged = true; buf.pl = Players.player3; break;
                    }


                    checkersList.Add(buf);

                    points[i].engaged = true;

                }
               
            }
            delete = new Checker[5];
            beatCheck = new Checker[5];
            for (int i = 0; i < 5; i++)
            {
                beatCheck[i] = null;
                delete[i] = null;
            }
            return checkersList;
        }

        public void setNonVisible()
        {
            foreach(Checker c in nextMove)
            {
                c.picBox.Visible = false;
            }
        }
        public List<PairOfPoints> initializePoints()
        {
            List<PairOfPoints> boardPoints = new List<PairOfPoints>();
            //white
            boardPoints.Add(new PairOfPoints(132, 423));
            boardPoints.Add(new PairOfPoints(194, 421));
            boardPoints.Add(new PairOfPoints(253, 417));
            boardPoints.Add(new PairOfPoints(315, 422));
            boardPoints.Add(new PairOfPoints(154, 388));
            boardPoints.Add(new PairOfPoints(220, 370));
            boardPoints.Add(new PairOfPoints(291, 377));
            boardPoints.Add(new PairOfPoints(358, 396));

            boardPoints.Add(new PairOfPoints(107, 368));
            boardPoints.Add(new PairOfPoints(180, 339));
            boardPoints.Add(new PairOfPoints(259, 323));
            boardPoints.Add(new PairOfPoints(333, 354));
            boardPoints.Add(new PairOfPoints(136, 318));
            boardPoints.Add(new PairOfPoints(217, 276));
            boardPoints.Add(new PairOfPoints(302, 297));
            boardPoints.Add(new PairOfPoints(381, 339));

            //black
            boardPoints.Add(new PairOfPoints(132, 52));
            boardPoints.Add(new PairOfPoints(108, 109));
            boardPoints.Add(new PairOfPoints(81, 166));
            boardPoints.Add(new PairOfPoints(43, 213));
            boardPoints.Add(new PairOfPoints(153, 89));
            boardPoints.Add(new PairOfPoints(133, 159));
            boardPoints.Add(new PairOfPoints(94, 214));
            boardPoints.Add(new PairOfPoints(44, 262));

            boardPoints.Add(new PairOfPoints(194, 57));
            boardPoints.Add(new PairOfPoints(183, 141));
            boardPoints.Add(new PairOfPoints(161, 215));
            boardPoints.Add(new PairOfPoints(94, 263));
            boardPoints.Add(new PairOfPoints(224, 109));
            boardPoints.Add(new PairOfPoints(219, 203));
            boardPoints.Add(new PairOfPoints(157, 265));
            boardPoints.Add(new PairOfPoints(80, 313));

            //grey
            boardPoints.Add(new PairOfPoints(455, 240));
            boardPoints.Add(new PairOfPoints(422, 187));
            boardPoints.Add(new PairOfPoints(387, 136));
            boardPoints.Add(new PairOfPoints(361, 80));
            boardPoints.Add(new PairOfPoints(410, 238));
            boardPoints.Add(new PairOfPoints(360, 189));
            boardPoints.Add(new PairOfPoints(334, 123));
            boardPoints.Add(new PairOfPoints(315, 56));


            boardPoints.Add(new PairOfPoints(416, 288));
            boardPoints.Add(new PairOfPoints(351, 238));
            boardPoints.Add(new PairOfPoints(301, 180));
            boardPoints.Add(new PairOfPoints(289, 99));
            boardPoints.Add(new PairOfPoints(360, 289));
            boardPoints.Add(new PairOfPoints(280, 239));
            boardPoints.Add(new PairOfPoints(258, 154));
            boardPoints.Add(new PairOfPoints(253, 63));

            for (int i = 0; i < 48; i++)
            {
                if (i<=15)
                {
                    boardPoints[i].playerBoard = Players.player1;
                }
                else if (i >= 32)
                {
                    boardPoints[i].playerBoard = Players.player3;
                }
                else
                {
                    boardPoints[i].playerBoard = Players.player2;
                }
            }
            //white next/prev
            boardPoints[0].nextRightPair = boardPoints[4];
            boardPoints[1].nextLeftPair = boardPoints[4]; boardPoints[1].nextRightPair = boardPoints[5];
            boardPoints[2].nextLeftPair = boardPoints[5]; boardPoints[2].nextRightPair = boardPoints[6];
            boardPoints[3].nextLeftPair = boardPoints[6]; boardPoints[3].nextRightPair = boardPoints[7];

            boardPoints[4].nextLeftPair = boardPoints[8]; boardPoints[4].nextRightPair = boardPoints[9];
            boardPoints[4].prevLeftPair = boardPoints[0]; boardPoints[4].prevRightPair = boardPoints[1];
            boardPoints[5].nextLeftPair = boardPoints[9]; boardPoints[5].nextRightPair = boardPoints[10];
            boardPoints[5].prevLeftPair = boardPoints[1]; boardPoints[5].prevRightPair = boardPoints[2];
            boardPoints[6].nextLeftPair = boardPoints[10]; boardPoints[6].nextRightPair = boardPoints[11];
            boardPoints[6].prevLeftPair = boardPoints[2]; boardPoints[6].prevRightPair = boardPoints[3];
            boardPoints[7].nextLeftPair = boardPoints[11];
            boardPoints[7].prevLeftPair = boardPoints[3];


            boardPoints[8].nextRightPair = boardPoints[12];
            boardPoints[8].prevRightPair = boardPoints[4];
            boardPoints[9].nextLeftPair = boardPoints[12]; boardPoints[9].nextRightPair = boardPoints[13];
            boardPoints[9].prevLeftPair = boardPoints[4]; boardPoints[9].prevRightPair = boardPoints[5];
            boardPoints[10].nextLeftPair = boardPoints[13]; boardPoints[10].nextRightPair = boardPoints[14];
            boardPoints[10].prevLeftPair = boardPoints[5]; boardPoints[10].prevRightPair = boardPoints[6];
            boardPoints[11].nextLeftPair = boardPoints[14]; boardPoints[11].nextRightPair = boardPoints[15];
            boardPoints[11].prevLeftPair = boardPoints[6]; boardPoints[11].prevRightPair = boardPoints[7];


            boardPoints[12].nextLeftPair = boardPoints[31]; boardPoints[12].nextRightPair = boardPoints[30];
            boardPoints[12].prevLeftPair = boardPoints[8]; boardPoints[12].prevRightPair = boardPoints[9];
            boardPoints[13].nextLeftPair = boardPoints[30]; boardPoints[13].nextRightPair = boardPoints[45]; boardPoints[13].nextCenterPair = boardPoints[29];
            boardPoints[13].prevLeftPair = boardPoints[9]; boardPoints[13].prevRightPair = boardPoints[10];
            boardPoints[14].nextLeftPair = boardPoints[45]; boardPoints[14].nextRightPair = boardPoints[44];
            boardPoints[14].prevLeftPair = boardPoints[10]; boardPoints[14].prevRightPair = boardPoints[11];
            boardPoints[15].nextLeftPair = boardPoints[44];
            boardPoints[15].prevLeftPair = boardPoints[11];

            //black next/prev
            boardPoints[16].nextRightPair = boardPoints[20];
            boardPoints[17].nextLeftPair = boardPoints[20]; boardPoints[17].nextRightPair = boardPoints[21];
            boardPoints[18].nextLeftPair = boardPoints[21]; boardPoints[18].nextRightPair = boardPoints[22];
            boardPoints[19].nextLeftPair = boardPoints[22]; boardPoints[19].nextRightPair = boardPoints[23];

            boardPoints[20].nextLeftPair = boardPoints[24]; boardPoints[20].nextRightPair = boardPoints[25];
            boardPoints[20].prevLeftPair = boardPoints[16]; boardPoints[20].prevRightPair = boardPoints[17];
            boardPoints[21].nextLeftPair = boardPoints[25]; boardPoints[21].nextRightPair = boardPoints[26];
            boardPoints[21].prevLeftPair = boardPoints[17]; boardPoints[21].prevRightPair = boardPoints[18];
            boardPoints[22].nextLeftPair = boardPoints[26]; boardPoints[22].nextRightPair = boardPoints[27];
            boardPoints[22].prevLeftPair = boardPoints[18]; boardPoints[22].prevRightPair = boardPoints[19];
            boardPoints[23].nextLeftPair = boardPoints[27];
            boardPoints[23].prevLeftPair = boardPoints[19];


            boardPoints[24].nextRightPair = boardPoints[28];
            boardPoints[24].prevRightPair = boardPoints[20];
            boardPoints[25].nextLeftPair = boardPoints[28]; boardPoints[25].nextRightPair = boardPoints[29];
            boardPoints[25].prevLeftPair = boardPoints[20]; boardPoints[25].prevRightPair = boardPoints[21];
            boardPoints[26].nextLeftPair = boardPoints[29]; boardPoints[26].nextRightPair = boardPoints[30];
            boardPoints[26].prevLeftPair = boardPoints[21]; boardPoints[26].prevRightPair = boardPoints[22];
            boardPoints[27].nextLeftPair = boardPoints[30]; boardPoints[27].nextRightPair = boardPoints[31];
            boardPoints[27].prevLeftPair = boardPoints[22]; boardPoints[27].prevRightPair = boardPoints[23];


            boardPoints[28].nextLeftPair = boardPoints[47]; boardPoints[28].nextRightPair = boardPoints[46];
            boardPoints[28].prevLeftPair = boardPoints[24]; boardPoints[28].prevRightPair = boardPoints[25];
            boardPoints[29].nextLeftPair = boardPoints[46]; boardPoints[29].nextRightPair = boardPoints[13]; boardPoints[29].nextCenterPair = boardPoints[45];
            boardPoints[29].prevLeftPair = boardPoints[25]; boardPoints[29].prevRightPair = boardPoints[26];
            boardPoints[30].nextLeftPair = boardPoints[13]; boardPoints[30].nextRightPair = boardPoints[12];
            boardPoints[30].prevLeftPair = boardPoints[26]; boardPoints[30].prevRightPair = boardPoints[27];
            boardPoints[31].nextLeftPair = boardPoints[12];
            boardPoints[31].prevLeftPair = boardPoints[27];

            //grey next/prev
            boardPoints[32].nextRightPair = boardPoints[36];
            boardPoints[33].nextLeftPair = boardPoints[36]; boardPoints[33].nextRightPair = boardPoints[37];
            boardPoints[34].nextLeftPair = boardPoints[37]; boardPoints[34].nextRightPair = boardPoints[38];
            boardPoints[35].nextLeftPair = boardPoints[38]; boardPoints[35].nextRightPair = boardPoints[39];

            boardPoints[36].nextLeftPair = boardPoints[40]; boardPoints[36].nextRightPair = boardPoints[41];
            boardPoints[36].prevLeftPair = boardPoints[32]; boardPoints[36].prevRightPair = boardPoints[33];
            boardPoints[37].nextLeftPair = boardPoints[41]; boardPoints[37].nextRightPair = boardPoints[42];
            boardPoints[37].prevLeftPair = boardPoints[33]; boardPoints[37].prevRightPair = boardPoints[34];
            boardPoints[38].nextLeftPair = boardPoints[42]; boardPoints[38].nextRightPair = boardPoints[43];
            boardPoints[38].prevLeftPair = boardPoints[34]; boardPoints[38].prevRightPair = boardPoints[35];
            boardPoints[39].nextLeftPair = boardPoints[43];
            boardPoints[39].prevLeftPair = boardPoints[35];


            boardPoints[40].nextRightPair = boardPoints[44];
            boardPoints[40].prevRightPair = boardPoints[36];
            boardPoints[41].nextLeftPair = boardPoints[44]; boardPoints[41].nextRightPair = boardPoints[45];
            boardPoints[41].prevLeftPair = boardPoints[36]; boardPoints[41].prevRightPair = boardPoints[37];
            boardPoints[42].nextLeftPair = boardPoints[45]; boardPoints[42].nextRightPair = boardPoints[46];
            boardPoints[42].prevLeftPair = boardPoints[37]; boardPoints[42].prevRightPair = boardPoints[38];
            boardPoints[43].nextLeftPair = boardPoints[46]; boardPoints[43].nextRightPair = boardPoints[47];
            boardPoints[43].prevLeftPair = boardPoints[38]; boardPoints[43].prevRightPair = boardPoints[39];

            boardPoints[44].nextLeftPair = boardPoints[15]; boardPoints[44].nextRightPair = boardPoints[14];
            boardPoints[44].prevLeftPair = boardPoints[40]; boardPoints[44].prevRightPair = boardPoints[41];
            boardPoints[45].nextLeftPair = boardPoints[14]; boardPoints[45].nextRightPair = boardPoints[29]; boardPoints[45].nextCenterPair = boardPoints[13];
            boardPoints[45].prevLeftPair = boardPoints[41]; boardPoints[45].prevRightPair = boardPoints[42];
            boardPoints[46].nextLeftPair = boardPoints[29]; boardPoints[46].nextRightPair = boardPoints[28];
            boardPoints[46].prevLeftPair = boardPoints[42]; boardPoints[46].prevRightPair = boardPoints[43];
            boardPoints[47].nextLeftPair = boardPoints[28];
            boardPoints[47].prevLeftPair = boardPoints[43];

            
            return boardPoints;
        }
        public List<Checker> initializeMove()
        {
            List<Checker> l = new List<Checker>();
            PairOfPoints Loc = new PairOfPoints(0, 0);
            l.Add(new Checker(Loc));
            l[0].picBox = pictureBox25;
            l[0].picBox.Visible = false;
            l.Add(new Checker(Loc));
            l[1].picBox = pictureBox26;
            l[1].picBox.Visible = false;
            l.Add(new Checker(Loc));
            l[2].picBox = pictureBox27;
            l[2].picBox.Visible = false;
            l.Add(new Checker(Loc));
            l[3].picBox = pictureBox28;
            l[3].picBox.Visible = false;
            l.Add(new Checker(Loc));
            l[4].picBox = pictureBox29;
            l[4].picBox.Visible = false;


            return l;
        }
        public void beatTheChecker(Checker checker1,Checker checkerToBeat, PairOfPoints location)
        {
            Console.WriteLine(checker1.location.x.ToString() );
            Console.WriteLine(" " + checkerToBeat.location.x );
            Console.WriteLine(location.x);
            if (checker1 == null || checkerToBeat == null || location == null) return;

            Console.WriteLine("  b  " );
            // check.picBox.Location = new Point(checker.location.x, checker.location.y);

            checker1.location.engaged = false;
            checker1.location = location;
            checker1.location.engaged = true;
            checker1.setLocation();
            checker1.isChecked = false;
            checker1.location.engaged = true;

            checkerToBeat.location.engaged = false;
            checkerToBeat.picBox.Visible = false;


        }
        public bool mustBeat(Players p , PictureBox setIsCheck)
        {
            bool i = false;
            setNonChecked();
            foreach (Checker checker in Checkers)
            {
                if (checker.pl != p || checker.picBox.Visible == false || checker == null) continue;

                
                
                Checker nextChecker;
                if(checker.location.playerBoard == checker.pl)
                {
                    //beat on its own board
                    nextChecker = findChecker(checker.location.nextLeftPair);
                    if (nextChecker != null && nextChecker.pl!=checker.pl)
                    {
                        //beat to the left
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if(nextChecker.location.nextLeftPair !=null && nextChecker.location.nextLeftPair.engaged == false)
                            {
                                nextMove[0].picBox.Visible = true;
                                nextMove[0].location = nextChecker.location.nextLeftPair;
                                nextMove[0].setLocation();
                                checker.isChecked = true;
                                nextMove[0].isChecked = true;
                                delete[0] = nextChecker;
                                beatCheck[0] = checker;
                                i = true;
                                
                            }
                        } 
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[0].picBox.Visible = true;
                                nextMove[0].location = nextChecker.location.prevRightPair;
                                nextMove[0].setLocation();
                                checker.isChecked = true;
                                nextMove[0].isChecked = true;
                                delete[0] = nextChecker;
                                beatCheck[0] = checker;
                                i = true;
                            }
                        }                        
                                                                    
                    }


                    nextChecker = findChecker(checker.location.nextRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the right
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextRightPair != null && nextChecker.location.nextRightPair.engaged == false)
                            {
                                nextMove[1].picBox.Visible = true;
                                nextMove[1].location = nextChecker.location.nextRightPair;
                                nextMove[1].setLocation();
                               checker.isChecked = true;
                                nextMove[1].isChecked = true;
                                delete[1] = nextChecker;
                                beatCheck[1] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[1].picBox.Visible = true;
                                nextMove[1].location = nextChecker.location.prevLeftPair;
                                nextMove[1].setLocation();
                               checker.isChecked = true;
                                nextMove[1].isChecked = true;
                                delete[1] = nextChecker;
                                beatCheck[1] = checker;
                                i = true;
                            }
                        }

                    }

                    nextChecker = findChecker(checker.location.nextCenterPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the right
                        
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[2].picBox.Visible = true;
                                nextMove[2].location = nextChecker.location.prevLeftPair;
                                nextMove[2].setLocation();
                               checker.isChecked = true;
                                nextMove[2].isChecked = true;
                                delete[2] = nextChecker;
                                beatCheck[2] = checker;
                                i = true;
                            }
                        }
                        
                    }


                    nextChecker = findChecker(checker.location.prevLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevleft
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[3].picBox.Visible = true;
                                nextMove[3].location = nextChecker.location.prevLeftPair;
                                nextMove[3].setLocation();
                                checker.isChecked = true;
                                nextMove[3].isChecked = true;
                                delete[3] = nextChecker;
                                beatCheck[3] = checker;
                                i = true;

                            }
                        }

                    }


                    nextChecker = findChecker(checker.location.prevRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevright
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[4].picBox.Visible = true;
                                nextMove[4].location = nextChecker.location.prevRightPair;
                                nextMove[4].setLocation();
                                checker.isChecked = true;
                                nextMove[4].isChecked = true;
                                beatCheck[4] = checker;
                                delete[4] = nextChecker;
                                i = true;

                            }
                        }
                        

                    }

                }
                else if(checker.location.playerBoard != checker.pl)
                {

                    nextChecker = findChecker(checker.location.prevRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the nextLeft
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[0].picBox.Visible = true;
                                nextMove[0].location = nextChecker.location.prevRightPair;
                                nextMove[0].setLocation();
                                checker.isChecked = true;
                                nextMove[0].isChecked = true;
                                delete[0] = nextChecker;
                                beatCheck[0] = checker;
                                i = true;

                            }
                        }                        
                    }
                    nextChecker = findChecker(checker.location.prevLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the nextright
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[1].picBox.Visible = true;
                                nextMove[1].location = nextChecker.location.prevLeftPair;
                                nextMove[1].setLocation();
                                checker.isChecked = true;
                                nextMove[1].isChecked = true;
                                delete[1] = nextChecker;
                                beatCheck[1] = checker;
                                i = true;

                            }
                        }
                    }


                    nextChecker = findChecker(checker.location.nextCenterPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevCenter
                        
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[2].picBox.Visible = true;
                                nextMove[2].location = nextChecker.location.prevLeftPair;
                                nextMove[2].setLocation();
                               checker.isChecked = true;
                                nextMove[2].isChecked = true;
                                delete[2] = nextChecker;
                                beatCheck[2] = checker;
                                i = true;
                            }
                        }
                    }

                    nextChecker = findChecker(checker.location.nextRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevleft
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextRightPair != null && nextChecker.location.nextRightPair.engaged == false)
                            {
                                nextMove[3].picBox.Visible = true;
                                nextMove[3].location = nextChecker.location.nextRightPair;
                                nextMove[3].setLocation();
                                checker.isChecked = true;
                                nextMove[3].isChecked = true;
                                delete[3] = nextChecker;
                                beatCheck[3] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[3].picBox.Visible = true;
                                nextMove[3].location = nextChecker.location.prevLeftPair;
                                nextMove[3].setLocation();
                                checker.isChecked = true;
                                nextMove[3].isChecked = true;
                                delete[3] = nextChecker;
                                beatCheck[3] = checker;
                                i = true;
                            }
                        }

                    }

                    nextChecker = findChecker(checker.location.nextLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevRight
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextLeftPair != null && nextChecker.location.nextLeftPair.engaged == false)
                            {
                                nextMove[4].picBox.Visible = true;
                                nextMove[4].location = nextChecker.location.nextLeftPair;
                                nextMove[4].setLocation();
                                checker.isChecked = true;
                                nextMove[4].isChecked = true;
                                delete[4] = nextChecker;
                                beatCheck[4] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[4].picBox.Visible = true;
                                nextMove[4].location = nextChecker.location.prevRightPair;
                                nextMove[4].setLocation();
                               checker.isChecked = true;
                                nextMove[4].isChecked = true;
                                delete[4] = nextChecker;
                                beatCheck[4] = checker;
                                i = true;
                            }
                        }

                    }
                }

                Checker setIsChecked = findChecker(setIsCheck);

                if (setIsChecked.isChecked == true)
                {
                    setNonChecked();setIsChecked.isChecked = true;
                }


            }
            return i;
        }

        public bool mustBeat(Players p, PictureBox setIsCheck,Checker checker)
        {
            bool i = false;
            setNonChecked();
            
                if (checker == null) return false;



                Checker nextChecker;
                if (checker.location.playerBoard == checker.pl)
                {
                    //beat on its own board
                    nextChecker = findChecker(checker.location.nextLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the left
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextLeftPair != null && nextChecker.location.nextLeftPair.engaged == false)
                            {
                                nextMove[0].picBox.Visible = true;
                                nextMove[0].location = nextChecker.location.nextLeftPair;
                                nextMove[0].setLocation();
                                checker.isChecked = true;
                                nextMove[0].isChecked = true;
                                delete[0] = nextChecker;
                                beatCheck[0] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[0].picBox.Visible = true;
                                nextMove[0].location = nextChecker.location.prevRightPair;
                                nextMove[0].setLocation();
                                checker.isChecked = true;
                                nextMove[0].isChecked = true;
                                delete[0] = nextChecker;
                                beatCheck[0] = checker;
                                i = true;
                            }
                        }

                    }


                    nextChecker = findChecker(checker.location.nextRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the right
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextRightPair != null && nextChecker.location.nextRightPair.engaged == false)
                            {
                                nextMove[1].picBox.Visible = true;
                                nextMove[1].location = nextChecker.location.nextRightPair;
                                nextMove[1].setLocation();
                                checker.isChecked = true;
                                nextMove[1].isChecked = true;
                                delete[1] = nextChecker;
                                beatCheck[1] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[1].picBox.Visible = true;
                                nextMove[1].location = nextChecker.location.prevLeftPair;
                                nextMove[1].setLocation();
                                checker.isChecked = true;
                                nextMove[1].isChecked = true;
                                delete[1] = nextChecker;
                                beatCheck[1] = checker;
                                i = true;
                            }
                        }

                    }

                    nextChecker = findChecker(checker.location.nextCenterPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the right

                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[2].picBox.Visible = true;
                                nextMove[2].location = nextChecker.location.prevLeftPair;
                                nextMove[2].setLocation();
                                checker.isChecked = true;
                                nextMove[2].isChecked = true;
                                delete[2] = nextChecker;
                                beatCheck[2] = checker;
                                i = true;
                            }
                        }

                    }


                    nextChecker = findChecker(checker.location.prevLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevleft
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[3].picBox.Visible = true;
                                nextMove[3].location = nextChecker.location.prevLeftPair;
                                nextMove[3].setLocation();
                                checker.isChecked = true;
                                nextMove[3].isChecked = true;
                                delete[3] = nextChecker;
                                beatCheck[3] = checker;
                                i = true;

                            }
                        }

                    }


                    nextChecker = findChecker(checker.location.prevRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevright
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[4].picBox.Visible = true;
                                nextMove[4].location = nextChecker.location.prevRightPair;
                                nextMove[4].setLocation();
                                checker.isChecked = true;
                                nextMove[4].isChecked = true;
                                beatCheck[4] = checker;
                                delete[4] = nextChecker;
                                i = true;

                            }
                        }


                    }

                }
                else if (checker.location.playerBoard != checker.pl)
                {

                    nextChecker = findChecker(checker.location.prevRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the nextLeft
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[0].picBox.Visible = true;
                                nextMove[0].location = nextChecker.location.prevRightPair;
                                nextMove[0].setLocation();
                                checker.isChecked = true;
                                nextMove[0].isChecked = true;
                                delete[0] = nextChecker;
                                beatCheck[0] = checker;
                                i = true;

                            }
                        }
                    }
                    nextChecker = findChecker(checker.location.prevLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the nextright
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[1].picBox.Visible = true;
                                nextMove[1].location = nextChecker.location.prevLeftPair;
                                nextMove[1].setLocation();
                                checker.isChecked = true;
                                nextMove[1].isChecked = true;
                                delete[1] = nextChecker;
                                beatCheck[1] = checker;
                                i = true;

                            }
                        }
                    }


                    nextChecker = findChecker(checker.location.nextCenterPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevCenter

                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[2].picBox.Visible = true;
                                nextMove[2].location = nextChecker.location.prevLeftPair;
                                nextMove[2].setLocation();
                                checker.isChecked = true;
                                nextMove[2].isChecked = true;
                                delete[2] = nextChecker;
                                beatCheck[2] = checker;
                                i = true;
                            }
                        }
                    }

                    nextChecker = findChecker(checker.location.nextRightPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevleft
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextRightPair != null && nextChecker.location.nextRightPair.engaged == false)
                            {
                                nextMove[3].picBox.Visible = true;
                                nextMove[3].location = nextChecker.location.nextRightPair;
                                nextMove[3].setLocation();
                                checker.isChecked = true;
                                nextMove[3].isChecked = true;
                                delete[3] = nextChecker;
                                beatCheck[3] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevLeftPair != null && nextChecker.location.prevLeftPair.engaged == false)
                            {
                                nextMove[3].picBox.Visible = true;
                                nextMove[3].location = nextChecker.location.prevLeftPair;
                                nextMove[3].setLocation();
                                checker.isChecked = true;
                                nextMove[3].isChecked = true;
                                delete[3] = nextChecker;
                                beatCheck[3] = checker;
                                i = true;
                            }
                        }

                    }

                    nextChecker = findChecker(checker.location.nextLeftPair);
                    if (nextChecker != null && nextChecker.pl != checker.pl)
                    {
                        //beat to the prevRight
                        if (nextChecker.location.playerBoard == checker.location.playerBoard)
                        {
                            if (nextChecker.location.nextLeftPair != null && nextChecker.location.nextLeftPair.engaged == false)
                            {
                                nextMove[4].picBox.Visible = true;
                                nextMove[4].location = nextChecker.location.nextLeftPair;
                                nextMove[4].setLocation();
                                checker.isChecked = true;
                                nextMove[4].isChecked = true;
                                delete[4] = nextChecker;
                                beatCheck[4] = checker;
                                i = true;

                            }
                        }
                        if (nextChecker.location.playerBoard != checker.location.playerBoard)
                        {
                            if (nextChecker.location.prevRightPair != null && nextChecker.location.prevRightPair.engaged == false)
                            {
                                nextMove[4].picBox.Visible = true;
                                nextMove[4].location = nextChecker.location.prevRightPair;
                                nextMove[4].setLocation();
                                checker.isChecked = true;
                                nextMove[4].isChecked = true;
                                delete[4] = nextChecker;
                                beatCheck[4] = checker;
                                i = true;
                            }
                        }

                    }
                }

                Checker setIsChecked = findChecker(setIsCheck);

                if (setIsChecked.isChecked == true)
                {
                    setNonChecked(); setIsChecked.isChecked = true;
                }


            
            return i;
        }
        public void setPlayerText()
        {
            if(turn==Players.player1)
                label1.Text = turn.ToString() + " turn (White)" ;
            else if(turn == Players.player2)
                label1.Text = turn.ToString() + " turn (Black)";
            else
                label1.Text = turn.ToString() + " turn (Grey)";

        }
        public void ClickOnCheck(PictureBox pic)
        {
            Checker checker =  findChecker(pic);
            setNonChecked();
            setNonVisible();
            checker.isChecked = true;

            if (checker.Queen == true)
            {
                Checker nextChecker = findAbstractChecker(checker.location.nextLeftPair);
                if (nextChecker != null)
                {

                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {

                        nextMove[0].location = nextChecker.location;
                        nextMove[0].setLocation();
                        nextMove[0].picBox.Visible = true;
                    }
                }
                nextChecker = findAbstractChecker(checker.location.nextRightPair);
                if (nextChecker != null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[1].location = nextChecker.location;
                        nextMove[1].setLocation();
                        nextMove[1].picBox.Visible = true;
                    }

                nextChecker = findAbstractChecker(checker.location.nextCenterPair);
                if (nextChecker != null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[2].location = nextChecker.location;
                        nextMove[2].picBox.Visible = true;
                        nextMove[2].setLocation();
                    }
                 nextChecker = findAbstractChecker(checker.location.prevLeftPair);
                if (nextChecker != null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[3].location = nextChecker.location;
                        nextMove[3].setLocation();
                        nextMove[3].picBox.Visible = true;
                    }

                nextChecker = findAbstractChecker(checker.location.prevRightPair);
                if (nextChecker != null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[4].location = nextChecker.location;
                        nextMove[4].setLocation();
                        nextMove[4].picBox.Visible = true;
                    }
            }
            else if (checker.pl == checker.location.playerBoard)
            {
                //Console.WriteLine(checker.location.nextLeftPair.x.ToString() + "  " +checker.location.nextLeftPair.y);
                Checker nextChecker = findAbstractChecker(checker.location.nextLeftPair);
                if (nextChecker != null)
                {
                    
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                       
                        nextMove[0].location = nextChecker.location;
                        nextMove[0].setLocation();
                        nextMove[0].picBox.Visible = true;
                    }
                }
                nextChecker = findAbstractChecker(checker.location.nextRightPair);
                if (nextChecker != null)
                   if (nextChecker.location != null && nextChecker.location.engaged == false)
                   {
                        nextMove[1].location = nextChecker.location;
                        nextMove[1].setLocation();
                        nextMove[1].picBox.Visible = true;
                    }

                nextChecker = findAbstractChecker(checker.location.nextCenterPair);
                if (nextChecker != null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[2].location = nextChecker.location;
                        nextMove[2].picBox.Visible = true;
                        nextMove[2].setLocation();
                    }
            }
            else
            {
                Checker nextChecker = findAbstractChecker(checker.location.prevLeftPair);
                if (nextChecker != null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[3].location = nextChecker.location;
                        nextMove[3].setLocation();
                        nextMove[3].picBox.Visible = true;
                    }

                nextChecker = findAbstractChecker(checker.location.prevRightPair);
                if(nextChecker!=null)
                    if (nextChecker.location != null && nextChecker.location.engaged == false)
                    {
                        nextMove[4].location = nextChecker.location;
                        nextMove[4].setLocation();
                        nextMove[4].picBox.Visible = true;
                    }

            }

        }
        public void ClickOnNextMove(PictureBox pic, Checker nextmove)
        {
            Checker checker = findAbstractChecker(pic);
           
            if (nextMove != null)
            {
                if (nextmove.isChecked == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (delete[i] != null) Console.WriteLine("next move: " + nextMove.IndexOf(nextmove) + " delete:" + i + "   x= " + delete[i].location.x + "   x= " + beatCheck[i].location.x);
                    }

                    Checker del = delete[nextMove.IndexOf(nextmove)];
                    Checker checker1 = findChecker();
                  
                    checker1 = beatCheck[nextMove.IndexOf(nextmove)];
                    

                    beatTheChecker(checker1, del, nextmove.location);

                   
                    for (int i = 0; i < 5; i++)
                    {
                        beatCheck[i] = null;
                        nextMove[i].isChecked = false;
                        delete[i] = null;
                    }
                    
                    setNonVisible();
                    setNonChecked();
                    checker1.SetQueen();
                    mustBeat(checker1.pl, checker1.picBox, checker1);
                    return;
                }
            }
           
                Checker check = findChecker();
                if (checker != null)
                {
                    check.location.engaged = false;
                    check.location = checker.location;
                    check.location.engaged = true;
                    check.setLocation();
                    check.isChecked = false;
                    check.location.engaged = true;
                    check.SetQueen();
                }
            setNonChecked();
            setNonVisible();
            }
        
        public int numbOfDeletes()
        {
            int a=0;
            for (int i = 0; i < 5; i++)
            {
                if (delete[i] != null) a++;
            }
            return a;
        }
        public int numbOfIsChecked()

        {
            int i=0;
            foreach(Checker ch in Checkers)
            {
                if (ch.isChecked == true) i++;
            }
            return i;
        }
        public void updateDesk()
        {
            bool[] z = new bool[8];

            if (deleted != Players.player1)
            {
                for (int i = 0; i < 8; i++)
                {

                    if (Checkers[i].picBox.Visible == false) z[i] = true;
                    else z[i] = false;

                }
                if (z[0] == z[1] && z[1] == z[2] && z[2] == z[3] && z[3] == z[4] && z[4] == z[5] && z[5] == z[6] && z[6] == z[7] && z[7] == true && deleted != Players.player3 && deleted != Players.player2 && deleted != Players.player1)
                {
                    deleted = Players.player1;
                }
                if (z[0] == z[1] && z[1] == z[2] && z[2] == z[3] && z[3] == z[4] && z[4] == z[5] && z[5] == z[6] && z[6] == z[7] && z[7] == true && (deleted ==Players.player2||deleted==Players.player3))
                {
                    if (deleted == Players.player2)
                        MessageBox.Show("COGRATULATION: player3 win");
                    else
                        MessageBox.Show("COGRATULATION: player2 win");
                    this.Close();
                }
            }


            if (deleted != Players.player2)
            {
                for (int i = 8; i < 16; i++)
                {

                    if (Checkers[i].picBox.Visible == false) z[i-8] = true;
                    else z[i-8] = false;

                }
                if (z[0] == z[1] && z[1] == z[2] && z[2] == z[3] && z[3] == z[4] && z[4] == z[5] && z[5] == z[6] && z[6] == z[7] && z[7] == true  && deleted != Players.player3 && deleted != Players.player2 && deleted != Players.player1)
                {
                    deleted = Players.player2;
                }
                if (z[0] == z[1] && z[1] == z[2] && z[2] == z[3] && z[3] == z[4] && z[4] == z[5] && z[5] == z[6] && z[6] == z[7] && z[7] == true && (deleted == Players.player1 || deleted == Players.player3))
                {
                    if (deleted == Players.player1)
                        MessageBox.Show("COGRATULATION: player3 win");
                    else
                        MessageBox.Show("COGRATULATION: player1 win");
                    this.Close();
                }
            }


            if (deleted != Players.player3)
            {
                for (int i = 16; i < 24; i++)
                {

                    if (Checkers[i].picBox.Visible == false) z[i-16] = true;
                    else z[i-16] = false;

                }
                if (z[0] == z[1] && z[1] == z[2] && z[2] == z[3] && z[3] == z[4] && z[4] == z[5] && z[5] == z[6] && z[6] == z[7] && z[7] == true && deleted != Players.player3 && deleted != Players.player2 && deleted != Players.player1)
                {
                    deleted = Players.player3;
                }
                if (z[0] == z[1] && z[1] == z[2] && z[2] == z[3] && z[3] == z[4] && z[4] == z[5] && z[5] == z[6] && z[6] == z[7] && z[7] == true && (deleted == Players.player2 || deleted == Players.player1))
                {
                    if (deleted == Players.player2)
                        MessageBox.Show("COGRATULATION: player1 win");
                    
                    else
                        MessageBox.Show("COGRATULATION: player2 win");
                    this.Close();
                }
            }

        }



        //----------------------------Yellow----------------------------
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            ClickOnNextMove(pictureBox29,nextMove[4]);
            Lab:

            if (numbOfDeletes() > 0) ;
            else if (turn == Players.player3) { turn = Players.player1; setPlayerText(); }
            else { turn++; setPlayerText(); }
            updateDesk();
            if ( turn == deleted) goto Lab;
            
            
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            ClickOnNextMove(pictureBox25,nextMove[0]);
            Lab:

            if (numbOfDeletes() > 0) ;
            else if (turn == Players.player3) { turn = Players.player1; setPlayerText(); }
            else { turn++; setPlayerText(); }
            updateDesk();
            if ( turn == deleted) goto Lab;
           
            
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            ClickOnNextMove(pictureBox28,nextMove[3]);
            Lab:

            if (numbOfDeletes() > 0) ;
            else if (turn == Players.player3) { turn = Players.player1; setPlayerText(); }
            else { turn++; setPlayerText(); }
            updateDesk();
            if ( turn == deleted) goto Lab;
           
            
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            ClickOnNextMove(pictureBox26,nextMove[1]);
            Lab:

            if (numbOfDeletes() > 0) ;
            else if (turn == Players.player3) { turn = Players.player1; setPlayerText(); }
            else { turn++; setPlayerText(); }
            updateDesk();
            if ( turn == deleted) goto Lab;
            
            
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            
            ClickOnNextMove(pictureBox27,nextMove[2]);
            Lab:

            if (numbOfDeletes() > 0) ;
            else if (turn == Players.player3) { turn = Players.player1; setPlayerText(); }
            else { turn++; setPlayerText(); }
            updateDesk();
            if (turn == deleted) goto Lab;
          
            
        }

   

        //---------White--------------------------------------------------------------
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox7) == false)
            {
                
                ClickOnCheck(pictureBox7);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox1) == false)
            {

                ClickOnCheck(pictureBox1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)

        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox2) == false)
            {

                ClickOnCheck(pictureBox2);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            updateDesk();

            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox3) == false)
            {

                ClickOnCheck(pictureBox3);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox4) == false)
            {

                ClickOnCheck(pictureBox4);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox6) == false)
            {

                ClickOnCheck(pictureBox6);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox5) == false)
            {

                ClickOnCheck(pictureBox5);
            }
        }

       
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player1) return;
            if (mustBeat(Players.player1, pictureBox8) == false)
            { 
                ClickOnCheck(pictureBox8);
            }
        }
        //--------------black-----------------------------------------
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox9) == false)
            {
                ClickOnCheck(pictureBox9);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox10) == false)
            {
                ClickOnCheck(pictureBox10);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox11) == false)
            {
                ClickOnCheck(pictureBox11);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox12) == false)
            {
                ClickOnCheck(pictureBox12);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2,  pictureBox13) == false)
            {
                ClickOnCheck(pictureBox13);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox14) == false)
            {
                ClickOnCheck(pictureBox14);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox16) == false)
            {
                ClickOnCheck(pictureBox16);
            }
        }

        
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player2) return;
            if (mustBeat(Players.player2, pictureBox15) == false)
            {
                ClickOnCheck(pictureBox15);
            }
        }
        //-----------------grey----------
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox17) == false)
            {
                ClickOnCheck(pictureBox17);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox18) == false)
            {
                ClickOnCheck(pictureBox18);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox20)== false)
            {
                ClickOnCheck(pictureBox20);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox19) == false)
            {
                ClickOnCheck(pictureBox19);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox21) == false)
            {
                ClickOnCheck(pictureBox21);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox22) == false)
            {
                ClickOnCheck(pictureBox22);
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox23) == false)
            {
                ClickOnCheck(pictureBox23);
            }
        }


        private void pictureBox24_Click(object sender, EventArgs e)
        {
            updateDesk();
            if (turn != Players.player3) return;
            if (mustBeat(Players.player3, pictureBox24) == false)
            {
                ClickOnCheck(pictureBox24);
            }
        }
    }
}
