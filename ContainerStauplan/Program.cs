using System;
using System.Collections.Generic;

namespace ContainerStauplan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Container> containerList = generateContainerList(13);

            generateAndPrintStauplan(containerList);
        }

        static void generateAndPrintStauplan(List<Container> containerList)
        {
            Stauplan stauplan = new Stauplan();
            bool b = false;
            for (int i = 0; i < containerList.Count; i++)
            {
                stauplan.InsertContainer(containerList[i]);
                if (i == 11)
                {
                    stauplan.Print();
                    b = true;
                }
            }

            if (!b)
            {
                stauplan.Print();
            }
        }

        static List<Container> generateContainerList(int numContianer)
        {
            List<Container> containerList = new List<Container>();
            int maxWeight = 20;
            for (int i = 0; i < numContianer; i++)
            {
                containerList.Add(new Container(i + 1, maxWeight - i));
            }
            return containerList;
        }
    }
}
