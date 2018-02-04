using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ScreenPosition
    {
        private int x, y;
        public ScreenPosition(int x, int y)
        {
            this.x = rangeCheckedX(x);
            this.y = rangeCheckedY(y);
        }
        public int X
        {
            get => x;
            set => x = rangeCheckedX(value);
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = rangeCheckedY(value);
            }
        }
        private static int rangeCheckedX(int x)
        {
            if (x >= 0 && x <= 1920)
                return x;
            else
                throw (new ArgumentOutOfRangeException("X", "argument is out of range"));
        }
        private static int rangeCheckedY(int y)
        {
            if (y >= 0 && y <= 1080)
                return y;
            else
                throw (new ArgumentOutOfRangeException("Y", "argument is out of range"));
        }

    }

}
