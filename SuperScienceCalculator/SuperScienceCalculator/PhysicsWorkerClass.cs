using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperScienceCalculator
{
    internal class PhysicsWorkerClass
    {
        
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

