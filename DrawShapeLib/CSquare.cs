using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public class CSquare : CRectangle
    {
        #region Constructeurs

        public CSquare() : base()
        {

        }
        public CSquare(int dim, Point p, Color c) : base(dim, dim, p, c)
        {

        }

        public CSquare(int dim, Point p, Color c, bool r) : base(dim, dim, p, c, r)
        {

        }

        #endregion

        #region Méthodes

        public override object Clone()
        {
            return base.Clone();
        }

        #endregion
    }
}
