using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public interface IDrawable : ICloneable
    {
        void Draw();
        void Draw(Graphics g);
        Point TopLeft { get; set; }
    }
}
