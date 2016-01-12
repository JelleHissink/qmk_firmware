using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class PhysicalKey
    {
        public PhysicalKey(double left, double top, double width = 1.0, double height = 1.0, double rotation = 0.0)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            Rotation = rotation;
        }

        public double Left { get; }
        public double Top { get; }

        public double Width { get; }
        public double Height { get; }

        public double Rotation { get; }

        public double MidX => Left + HalfWidth;
        public double MidY => Top + HalfHeight;

        public double HalfWidth => Width / 2.0;
        public double HalfHeight => Height / 2.0;
    }
}
