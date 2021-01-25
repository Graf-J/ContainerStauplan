using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerStauplan
{
    class Stauplan
    {
        public Bay BayOne = new Bay();
        public Bay BayTwo = new Bay();
        public Bay BayThree = new Bay();

        public void InsertContainer(Container container)
        {
            int bay1Weight = BayOne.GetWeight();
            int bay2Weight = BayTwo.GetWeight();
            int bay3Weight = BayThree.GetWeight();

            if (bay1Weight <= bay2Weight && bay1Weight <= bay3Weight)
            {
                BayOne.InsertContainer(container);
            }
            else if (bay2Weight <= bay1Weight && bay2Weight <= bay3Weight)
            {
                BayTwo.InsertContainer(container);
            }
            else
            {
                BayThree.InsertContainer(container);
            }
        }

        public void Print()
        {
            Console.WriteLine($"BayOne: {BayOne.GetInfo()}");
            Console.WriteLine($"BayTwo: {BayTwo.GetInfo()}");
            Console.WriteLine($"BayThree: {BayThree.GetInfo()}");
        }
    }
}
