using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVektor {
    class Program {
        static void Main(string[] args) {
            int[] someNumbers = new int[10];
            bool validData = false;
            int theNumber = 7;

            for(int i = 0; i < 10; i++) {
                do {
                    Console.Write("Skriv ett tal: ");
                    try {
                        someNumbers[i] = Convert.ToInt32(Console.ReadLine());
                        validData = true;
                    }
                    catch(FormatException) {
                        Console.WriteLine("Var snäll och skriv endast heltal");
                        i--;
                    }
                    catch(Exception ex) {
                        Console.WriteLine(ex.Message);
                        i--;
                    }
                } while(!validData);
            }
            Console.WriteLine("Tack! \n");

            for(int i = 0; i < 10; i++) {
                Console.Write("Index {0} har talet: ", i);
                if(someNumbers[i] == theNumber) {
                    Console.WriteLine(someNumbers[i] + " !"); // The number is being noticed
                }
                else {
                    Console.WriteLine(someNumbers[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
