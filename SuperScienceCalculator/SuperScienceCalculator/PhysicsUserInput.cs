using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperScienceCalculator
{
    internal class PhysicsUserInput
    {
        private String userInput = "";
        
        private static PhysicsWorkerClass myPysicsWorker = new PhysicsWorkerClass();

        public PhysicsUserInput() 
        {
            
        }

        //..........................................................................................//
        public void Intro() 
        {
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine("WELCOME TO THE PHYSICS CALCULATOR APPLICATION");
            Console.WriteLine("/////////////////////////////////////////////");

            Console.WriteLine("Press Enter to Continue...");
            Console.ReadKey();

            UserDataCapture();
        }

        //..........................................................................................//
        public void UserDataCapture()
        {
            Console.WriteLine("\n1. To Calculate Momentum \n2.");

            Console.Write("\nWhat would you like to Calculate? Enter a number: ");
            userInput = Console.ReadLine();

            if (userInput.Equals("1")) 
            {
                MomentumInput();
            }
        }

        //..........................................................................................//

        public void MomentumInput()
        {
            Console.Write("\nWould you like to calculate just Momentum or the change in momentum? Enter [1] Momentum or [2] Change in Momentum: ");
            userInput = Console.ReadLine();

            if (userInput.Equals("1"))
            {
                Console.WriteLine("Definition: \n1. Momentum is an indication of how hard it takes to stop a moving object.\n2. Momentum is Calculated as the product (p) of mass (m) and velocity (v)");
                Console.WriteLine("\nTherefore, p = mv");
                Console.Write("You will need the mass of your object and the velocity.\n");

                myPysicsWorker.Momentum();
            }
            else 
            {
                Console.WriteLine("\nDefinition: \nIf the mass or velocity or both change, the momentum will change.\n");
                Console.WriteLine("\nFormula, []p = Pf - Pi = (Mf x Vf) - (Mi x Vi)\n");

                Console.WriteLine("Fun Fact: Newtons Second law makes use of this calculation!\n");

                Console.Write("You will need the final mass and velocity of your object as well as the intial mass and velocity.\n");

                myPysicsWorker.ChangeInMomentum();

            }

            
        }

    }
}
//...........................................................EndOfClass...............................................................//
