using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVektor {
    class Program {
        static void Main(string[] args) {
            int[] someNumbers = new int[10];
            bool validData = true;
            int theNumber = 7;

            for(int i = 0; i < 10; i++) {
                do {
                    Console.Write("Skriv ett tal: ");
                    try {
                        someNumbers[i] = Convert.ToInt32(Console.ReadLine());
                        validData = true;   // just to be clear
                    }
                    catch(FormatException) {
                        Console.WriteLine("Var snäll och skriv endast heltal");
                        validData = false;  // to make it loop after an exception
                    }
                    catch(Exception ex) {
                        Console.WriteLine(ex.Message);
                        validData = false;  // to make it loop after an exception
                    }
                } while(validData == false);
            }
            Console.WriteLine("Tack! \n");

            for(int i = 0; i < 10; i++) {
                Console.Write("Index {0} har talet: ", i);
                if(someNumbers[i] == theNumber) {
                    Console.WriteLine(someNumbers[i] + " !"); // 
                }
                else {
                    Console.WriteLine(someNumbers[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
