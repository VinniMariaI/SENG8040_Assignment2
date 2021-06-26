using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleSolver
{
   public static class TraiangleSolver
    {
        //string Analyze();
        public static string Analyze(int side1, int side2, int side3)
        {
            if ((side1 + side2) <= side3 || side2 + side3 <= side1 || side3 + side1 <= side2)
                return "do not form a Traingle";

            else
            {
                if (side1 == side2 && side2 == side3)
                    return "form an Equilateral Traingle";
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                    return "form an Isoceles Triangle";
                else
                    return "form a Scalene Traingle";

            }
        }
    }
}
