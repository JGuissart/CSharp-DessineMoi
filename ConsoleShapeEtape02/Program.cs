using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DrawShapeLib;

namespace ConsoleShapeEtape02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instanciations de différentes formes ...");

            CCircle c1, c2, c3, c4;
            CRectangle r1, r2, r3, r4;
            CSquare s1, s2, s3, s4;

            c1 = new CCircle(12, new Point(5, 5), Color.Black);
            c2 = new CCircle(7, new Point(7, 9), Color.Yellow, true);
            c3 = new CCircle(9, new Point(10, 10), Color.Lavender);
            c4 = new CCircle(25, new Point(4, 9), Color.LightGray, true);

            r1 = new CRectangle(12, 15, new Point(5, 5), Color.LightSlateGray);
            r2 = new CRectangle(10, 11, new Point(7, 8), Color.PaleGoldenrod, true);
            r3 = new CRectangle(12, 13, new Point(9, 10), Color.Purple);
            r4 = new CRectangle(14, 15, new Point(11, 12), Color.SandyBrown, true);

            s1 = new CSquare(12, new Point(0, 1), Color.Magenta);
            s2 = new CSquare(13, new Point(2, 3), Color.Gray, true);
            s3 = new CSquare(14, new Point(4, 5), Color.Gainsboro);
            s4 = new CSquare(15, new Point(6, 7), Color.DarkViolet, true);

            Console.WriteLine("Creation de la liste des formes ...");

            List<IDrawable> listeForme = new List<IDrawable>();

            listeForme.Add(c1);
            listeForme.Add(c2);
            listeForme.Add(c3);
            listeForme.Add(c4);
            listeForme.Add(r1);
            listeForme.Add(r2);
            listeForme.Add(r3);
            listeForme.Add(r4);
            listeForme.Add(s1);
            listeForme.Add(s2);
            listeForme.Add(s3);
            listeForme.Add(s4);

            Console.WriteLine("Affichage des formes\n\n");

            foreach (IDrawable elem in listeForme)
            {
                elem.Draw();
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
