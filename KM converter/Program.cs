using System;

namespace KM_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plese enter a distnace in km: ");
            ConvertKMtoM(double.Parse(Console.ReadLine()));

        }//End of Main

        //Creating function

        static void ConvertKMtoM(double km)
        {
            double miles = km * .6214;
            Console.WriteLine("{0} km = {1:F2} miles", km, miles);
        }

        //End of Functions
    }


}
