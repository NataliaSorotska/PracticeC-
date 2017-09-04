using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.СonverterOfQuantities();
            Console.ReadLine();
        }

        public void СonverterOfQuantities()
        {
            Console.WriteLine("     Hello you open converter of quantities, please make a choise ");


            while (true)
            {

                Console.WriteLine(" If you want convert kg-pound please write 1, C-F write 2, km-ml write 3 or 4 to exit and press the enter");
                string c = Console.ReadLine();
                int value = Int32.Parse(c);
                //if (value < 0 || value > 4)
                //{


                    switch (value)
                    {
                        case 1:
                            Console.WriteLine(
                                "Please write 1 when you want convert kg-pound or 2 when ft-pound and press the enter");
                            string strValueKgOrPound = Console.ReadLine();
                            int intValueKgOrPound = Int32.Parse(strValueKgOrPound);
                            switch (intValueKgOrPound)
                            {
                                case 1:
                                    KgToPound();
                                    break;
                                case 2:
                                    PoundToKg();
                                    break;
                            default: Console.WriteLine("Please type corect data"); break;
                        }
                            break;
                        case 2:
                            Console.WriteLine(
                                "Please, write 1 when you whant convert celsius -fahrenheit or 2 when fahrenheit-celsius");
                            string strValueCToF = Console.ReadLine();
                            int intValueCToF = Int32.Parse(strValueCToF);
                            switch (intValueCToF)
                            {
                                case 1:
                                    CelsiToFareheit();
                                    break;
                                case 2:
                                    FarenheitToCelsi();
                                    break;
                            default: Console.WriteLine("Please type corect data"); break;
                        }
                            break;
                        case 3:
                            Console.WriteLine(
                                "Please, write 1 when you whant convert celsius -fahrenheit or 2 when fahrenheit-celsius");
                            string strValueKmToMil = Console.ReadLine();
                            int intValueKmtoMil = Int32.Parse(strValueKmToMil);
                            switch (intValueKmtoMil)
                            {
                                case 1:
                                    KilometrsToMIles();
                                    break;
                                case 2:
                                    MilesToKilometrs();
                                    break;
                            default: Console.WriteLine("Please type corect data"); break;
                            }
                            break;

                        default:
                            Console.WriteLine("Please type corect data");
                            break;
                    }
                
               
            }
        }

        public void KgToPound()
        {
            Console.WriteLine("Write value, please and press the enter ");
            string value = Console.ReadLine();
            int intValue = Int32.Parse(value);
            double convertValue = (double)intValue * 2.2;
            Console.WriteLine($"You value is {convertValue}");
        }

        public void PoundToKg()
        {
            Console.WriteLine("Write value, please: ");
            string value = Console.ReadLine();
            int intValue = Int32.Parse(value);
            double convertValue = (double)intValue * 0.45;
            Console.WriteLine($"You value is {convertValue}");
        }

        public void CelsiToFareheit()
        {
            Console.WriteLine("Write value, please and press the enter ");
            string value = Console.ReadLine();
            int intValue = Int32.Parse(value);
            double convertValue = (double)intValue * 1.8 + 32;
            Console.WriteLine($"You value is {convertValue}");
        }

        public void FarenheitToCelsi()
        {
            Console.WriteLine("Write value, please and press the enter ");
            string value = Console.ReadLine();
            int intValue = Int32.Parse(value);
            double convertValue = ((double)intValue - 32) / 1.8;
            Console.WriteLine($"You value is {convertValue}");
        }

        public void KilometrsToMIles()
        {
            Console.WriteLine("Write value, please and press the enter ");
            string value = Console.ReadLine();
            int intValue = Int32.Parse(value);
            double convertValue = (double)intValue / 1.609344;
            Console.WriteLine($"You value is {convertValue}");
        }
        public void MilesToKilometrs()
        {
            Console.WriteLine("Write value, please and press the enter ");
            string value = Console.ReadLine();
            int intValue = Int32.Parse(value);
            double convertValue = (double)intValue * 1.609344;
            Console.WriteLine($"You value is {convertValue}");
        }
    }
}
