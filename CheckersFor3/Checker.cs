using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersFor3
{
    public enum  Players
    {
        player1,
        player2,player3,
    }
    public class Checker
    {
        public Players pl;
        public bool isChecked = false;
        public Checker(PairOfPoints Location) { location = Location; }
        public PairOfPoints location;


        public bool Queen = false;
        public PictureBox picBox;
        

      public void setLocation()
        {
            picBox.Location = new System.Drawing.Point(location.x, location.y);
        }

        public void SetQueen()
        {
            if (pl !=location.playerBoard && location.prevLeftPair == null && location.prevRightPair == null)
            {
                picBox.Image = picBox.ErrorImage;
                Queen = true;
            }

        }
    }
}
