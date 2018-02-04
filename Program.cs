using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Law_of_Sines_Calculator
{
    class Program
    {
        static void Main()
        {



            TriangleSide triangleSide1 = new TriangleSide();
            // Angle 1
          
                Console.WriteLine("Please enter the known angle in degrees (decimal) of the oblique triangle");  // Get the first known angle from the user.
                string knownAngle1 = Console.ReadLine();
                triangleSide1.KnownAngle1 = Convert.ToDouble(knownAngle1);
         

            double knownAngleRadians = (triangleSide1.KnownAngle1 * Math.PI) / 180; // Convert angle (degrees) into radians.
                triangleSide1.KnownAngleRadians1 = knownAngleRadians;

                double knownAngleSine = Math.Sin(triangleSide1.KnownAngleRadians1); // Convert angle radians into Sine
                triangleSide1.KnownAngleSine1 = knownAngleSine;

                Console.WriteLine($"The sine of the angle is: {triangleSide1.KnownAngleSine1}");
         

            // Side 1
            Console.WriteLine("Please enter the length of the side opposite to the first known angle"); // Get side opposite to first known angle
            string knownSide1 = Console.ReadLine();
            triangleSide1.KnownSide1 = Convert.ToDouble(knownSide1);

            // Angle 2
            Console.WriteLine("Please enter the known angle in degrees (decimal) of the oblique triangle, opposite to the unknown side: "); // Get the second known angle from the user.
            string knownAngle2 = Console.ReadLine();
            triangleSide1.KnownAngle2 = Convert.ToDouble(knownAngle2);

            double knownAngleRadians2 = (triangleSide1.KnownAngle2 * Math.PI) / 180; // Convert angle (degrees) into radians.
            triangleSide1.KnownAngleRadians2 = knownAngleRadians2;

            double knownAngleSine2 = Math.Sin(triangleSide1.KnownAngleRadians2); // Convert angle radians into Sine
            triangleSide1.KnownAngleSine2 = Convert.ToDouble(knownAngleSine2);

            Console.WriteLine($"The sine of the second angle is: {triangleSide1.KnownAngleSine2}");


            // Unknown Side
            double uknownSide = ((triangleSide1.KnownSide1 * triangleSide1.KnownAngleSine2) / knownAngleSine); // Calculate unknown side using law of sines: sin(A) / A = sin(B) / B = sin(C) / C
            triangleSide1.UnKnownSide1 = Convert.ToDouble(uknownSide);

            Console.WriteLine($"\nThe length of the unknown side is: {triangleSide1.UnKnownSide1}");

        }
    }

}
