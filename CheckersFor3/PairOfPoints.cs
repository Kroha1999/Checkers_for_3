using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersFor3
{
    public class PairOfPoints
    {
        public Players playerBoard;
        public PairOfPoints(int X, int Y) { x = X; y = Y; }
        public int x;
        public int y;
        public PairOfPoints nextLeftPair =null, nextRightPair=null, nextCenterPair = null;
        public PairOfPoints prevLeftPair=null, prevRightPair=null;


        public bool engaged = false;


        

    }

    
}
