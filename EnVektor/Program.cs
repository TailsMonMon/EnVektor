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

            for(int i = 0; i < 10; i++) {
                do {
                    Console.Write("Skriv ett tal: ");
                    try {
                        someNumbers[i] = Convert.ToInt32(Console.ReadLine());
                        validData = true;
                    }
                    catch(FormatException) {
                        Console.WriteLine("Var snäll och skriv endast heltal");
                        validData = false;
                    }
                    catch(Exception ex) {
                        Console.WriteLine(ex.Message);
                        validData = false;
                    }
                } while(validData == false);
            }
            Console.WriteLine("Tack!");
            Console.ReadKey();
        }
    }
}
