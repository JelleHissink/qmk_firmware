using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class Ergodox : Keyboard
    {
        private const double right = 8.0;

        public Ergodox()
            : base(
                // left
                Key(y: 30, x: 0, w: 81, h: 54),
                Key(y: 30, x: 81, w: 54, h: 54),
                Key(y: 17, x: 135, w: 54, h: 54),
                Key(y: 10, x: 189, w: 54, h: 54),
                Key(y: 17, x: 243, w: 54, h: 54),
                Key(y: 23, x: 297, w: 54, h: 54),
                Key(y: 23, x: 351, w: 54, h: 54),

                Key(y: 84, x: 0, w: 81, h: 54),
                Key(y: 84, x: 81, w: 54, h: 54),
                Key(y: 71, x: 135, w: 54, h: 54),
                Key(y: 64, x: 189, w: 54, h: 54),
                Key(y: 71, x: 243, w: 54, h: 54),
                Key(y: 77, x: 297, w: 54, h: 54),
                Key(y: 77, x: 351, w: 54, h: 81),

                Key(y: 138, x: 0, w: 81, h: 54),
                Key(y: 138, x: 81, w: 54, h: 54),
                Key(y: 125, x: 135, w: 54, h: 54),
                Key(y: 118, x: 189, w: 54, h: 54),
                Key(y: 125, x: 243, w: 54, h: 54),
                Key(y: 131, x: 297, w: 54, h: 54),

                Key(y: 192, x: 0, w: 81, h: 54),
                Key(y: 192, x: 81, w: 54, h: 54),
                Key(y: 179, x: 135, w: 54, h: 54),
                Key(y: 172, x: 189, w: 54, h: 54),
                Key(y: 179, x: 243, w: 54, h: 54),
                Key(y: 185, x: 297, w: 54, h: 54),
                Key(y: 158, x: 351, w: 54, h: 81),

                Key(y: 246, x: 27, w: 54, h: 54),
                Key(y: 246, x: 81, w: 54, h: 54),
                Key(y: 233, x: 135, w: 54, h: 54),
                Key(y: 226, x: 189, w: 54, h: 54),
                Key(y: 233, x: 243, w: 54, h: 54),

                // start thumbpad 
                Key(y: 228, x: 406, w: 54, h: 54, r: 30),
                Key(y: 255, x: 453, w: 54, h: 54, r: 30),
                Key(y: 302, x: 426, w: 54, h: 54, r: 30),
                Key(y: 244, x: 319, w: 54, h: 108, r: 30),
                Key(y: 271, x: 366, w: 54, h: 108, r: 30),
                Key(y: 348, x: 399, w: 54, h: 54, r: 30),
                // end thumbpad 

                // right 
                Key(y: 23, x: 650, w: 54, h: 54),
                Key(y: 23, x: 704, w: 54, h: 54),
                Key(y: 17, x: 758, w: 54, h: 54),
                Key(y: 10, x: 812, w: 54, h: 54),
                Key(y: 17, x: 866, w: 54, h: 54),
                Key(y: 30, x: 920, w: 54, h: 54),
                Key(y: 30, x: 974, w: 81, h: 54),

                Key(y: 77, x: 650, w: 54, h: 81),
                Key(y: 77, x: 704, w: 54, h: 54),
                Key(y: 71, x: 758, w: 54, h: 54),
                Key(y: 64, x: 812, w: 54, h: 54),
                Key(y: 71, x: 866, w: 54, h: 54),
                Key(y: 84, x: 920, w: 54, h: 54),
                Key(y: 84, x: 974, w: 81, h: 54),

                Key(y: 131, x: 704, w: 54, h: 54),
                Key(y: 125, x: 758, w: 54, h: 54),
                Key(y: 118, x: 812, w: 54, h: 54),
                Key(y: 125, x: 866, w: 54, h: 54),
                Key(y: 138, x: 920, w: 54, h: 54),
                Key(y: 138, x: 974, w: 81, h: 54),

                Key(y: 158, x: 650, w: 54, h: 81),
                Key(y: 185, x: 704, w: 54, h: 54),
                Key(y: 179, x: 758, w: 54, h: 54),
                Key(y: 172, x: 812, w: 54, h: 54),
                Key(y: 179, x: 866, w: 54, h: 54),
                Key(y: 192, x: 920, w: 54, h: 54),
                Key(y: 192, x: 974, w: 81, h: 54),

                Key(y: 233, x: 758, w: 54, h: 54),
                Key(y: 226, x: 812, w: 54, h: 54),
                Key(y: 233, x: 866, w: 54, h: 54),
                Key(y: 246, x: 920, w: 54, h: 54),
                Key(y: 246, x: 974, w: 54, h: 54),

                // start thumbpad 
                Key(y: 255, x: 548, w: 54, h: 54, r: -30),
                Key(y: 228, x: 595, w: 54, h: 54, r: -30),
                Key(y: 302, x: 575, w: 54, h: 54, r: -30),
                Key(y: 348, x: 602, w: 54, h: 54, r: -30),
                Key(y: 271, x: 635, w: 54, h: 108, r: -30),
                Key(y: 244, x: 682, w: 54, h: 108, r: -30)
                // end thumbpad 
            )
        {
        }
    }
}
