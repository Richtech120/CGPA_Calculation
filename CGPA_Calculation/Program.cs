using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPA_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nam1 = Console.ReadLine();
            Console.Write("Semester: ");
            string sem1 = Console.ReadLine();
            Console.Write("Enter your English score: ");
            double eng1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Maths score: ");
            double mth1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your history score: ");
            double his1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Pysics score: ");
            double phy1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your German score: ");
            double ger1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Chemistry score: ");
            double chm1 = Convert.ToDouble(Console.ReadLine());


            //GPA1();
            double TotalCunite = 7;
            double GPA1 = (eng1 + mth1 + his1 + phy1 + ger1 + chm1) / TotalCunite;

            Console.WriteLine("The " + sem1 + " result of " + nam1 + " is " + GPA1);
            // Console.WriteLine(GPA1()/TotalCunite);
            //Assignment to write a method that passes those parameters inside 
            // the main total score divided by the credit unite
            /*GP is total score didvided by the credit unite
             so that means*/
            Console.WriteLine();
            Console.WriteLine();

            if (eng1 > 75)
            {
                Console.WriteLine("English Grade A");
            }
            else if (eng1 > 50)
            {
                Console.WriteLine("English Grade B");
            }
            else if (eng1 > 35)
            {
                Console.WriteLine("English Grade C");
            }
            else if (eng1 > 20)
            {
                Console.WriteLine("English Grade D");
            }
            else
            {
                Console.WriteLine("English Grade F");
            }

            if (mth1 > 75)
            {
                Console.WriteLine("Maths Grade A");
            }
            else if (mth1 > 50)
            {
                Console.WriteLine("Maths Grade B");
            }
            else if (mth1 > 35)
            {
                Console.WriteLine("Maths Grade C");
            }
            else if (mth1 > 20)
            {
                Console.WriteLine("Maths Grade D");
            }
            else
            {
                Console.WriteLine("Maths Grade F");
            }



            if (his1 > 75)
            {
                Console.WriteLine("History Grade A");
            }
            else if (his1 > 50)
            {
                Console.Write("History Grade B");
            }
            else if (his1 > 35)
            {
                Console.WriteLine("History Grade C");
            }
            else if (his1 > 20)
            {
                Console.WriteLine("History Grade D");
            }
            else
            {
                Console.WriteLine("History Grade F");
            }



            if (phy1 > 75)
            {
                Console.WriteLine("Physics Grade A");
            }
            else if (phy1 > 50)
            {
                Console.WriteLine("Physics Grade B");
            }
            else if (phy1 > 35)
            {
                Console.WriteLine("Physics Grade C");
            }
            else if (phy1 > 20)
            {
                Console.WriteLine("Physics Grade D");
            }
            else
            {
                Console.WriteLine("Physics Grade F");
            }


            if (ger1 > 75)
            {
                Console.WriteLine("German Grade A");
            }
            else if (ger1 > 50)
            {
                Console.WriteLine("German Grade B");
            }
            else if (ger1 > 35)
            {
                Console.WriteLine("German Grade C");
            }
            else if (ger1 > 20)
            {
                Console.WriteLine("German Grade D");
            }
            else
            {
                Console.WriteLine("German Grade F");
            }


            if (chm1 > 75)
            {
                Console.WriteLine("Chemistry Grade A");
            }
            else if (chm1 > 50)
            {
                Console.WriteLine("Chemistry Grade B");
            }
            else if (chm1 > 35)
            {
                Console.WriteLine("Chemistry Grade C");
            }
            else if (chm1 > 20)
            {
                Console.WriteLine("Chemistry Grade D");
            }
            else
            {
                Console.WriteLine("Chemistry Grade F");
            }

            Console.WriteLine();
            Console.WriteLine();


            


            Console.ReadLine();
        }

        /*private static void GPA1(double eng1, double mth1, double his1, double phy1, double ger1, double chm1)
        {
            Console.Write(eng1 + mth1 + his1 + phy1 + ger1 + chm1);
        }*/
        static double GPA1(double eng1, double mth1, double his1, double phy1, double ger1, double chm1)
        {
            return eng1 + mth1 + his1 + phy1 + ger1 + chm1;
        }
    }
}
