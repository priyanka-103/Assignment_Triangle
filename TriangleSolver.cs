using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string outputString = "";

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side3 + side2 <= side1)
            {
                outputString = "Output:\nDoesn't form a triangle\n";               
            }
            
            else
            {
                outputString = "Output:\nForms a triangle";

                if (side1 != side2 && side2 != side3 && side1 != side3)
                {
                    outputString = String.Concat(outputString, "\nThis Triangle is Scalene\n\n");
                }
                else if (((side1 == side2) && (side1 != side3)) || ((side2 == side3) && (side2 != side1)) || ((side1 == side3) && (side1 != side2)))
                {
                    outputString = String.Concat(outputString, "\nThis Triangle is Isosceles\n\n");
                }
                else if (side1==side2 && side2==side3)
                {
                    outputString=String.Concat(outputString, "\nThis Triangle is Equilateral\n\n");
                }
                
            }


            return outputString;
        }


    }
}
