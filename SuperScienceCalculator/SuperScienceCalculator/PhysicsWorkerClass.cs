using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperScienceCalculator
{
    internal class PhysicsWorkerClass
    {
        //Physical constants
        private Double ACCELERATION = 9.8;                      // Acceleration Due To Gravity.
        private Double UNIGRAVCON = 6.67 * 10e-11;              // Universal Gravitational Constant.
        private Double SPEEDOFLIGHT = 3.0 * 10e11;              // Speed Of Light In A Vaccum.
        private Double PLNKSCON = 6.63 * 10e-34;                // Planck's Constant.
        private Double COULBCONS = 9.0 * 10e9;                  // Coulomb's Constant.
        private Double CHARGOFELECTRON = -1.6 * 10e-19;         // Charge On Electron.
        private Double ELECTRONMASS = 9.11 * 10e-31;            // Electron Mass.




        public PhysicsWorkerClass() 
        {
        
        }

        //..........................................................................................//
        public void Momentum()
        {
            Double objectMass = 0.0;
            Double objectVelocity = 0.0;

            Console.Write("\nEnter the mass (kg) of your object: ");
            objectMass = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter the velocity (m.s) of your object: ");
            objectVelocity = Double.Parse(Console.ReadLine());


            Console.Write("\nThe momentum of your object is: " + ((int)MomentumCalc(objectMass, objectVelocity)) + " kg.m.s\n");
        }

        //..........................................................................................//

        public void ChangeInMomentum()
        {
            Double objectFinallMass = 0.0;
            Double objectFinalVelocity = 0.0;

            Double objectIntialMass = 0.0;
            Double objectIntialVelocity = 0.0;

            Console.Write("\nEnter the final mass (kg) of your object: ");
            objectFinallMass = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter the final velocity (m.s) of your object: ");
            objectFinalVelocity = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter the intial mass (kg) of your object: ");
            objectIntialMass = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter the intial velocity (m.s) of your object: ");
            objectIntialVelocity = Double.Parse(Console.ReadLine());


            Console.Write("\nThe Change in momentum of your object is: " + ((int)MomentumChangeCalc(objectFinallMass, objectFinalVelocity, objectIntialMass, objectIntialVelocity)) 
                        + " kg.m.s in the direction of motion\n");
        }

        //..........................................................................................//
        public Double MomentumCalc(Double mass, Double velocity) => mass * velocity;    // Calculating total Momentum using mass and velocity

        public Double MomentumChangeCalc(Double massF, Double velocityF, Double massI, Double velocityI) => (massF * velocityF) + (-1 * (massI * velocityI));    // Calculating total CHange in Momentum using mass and velocity





    }
}
//...........................................................EndOfClass...............................................................//

