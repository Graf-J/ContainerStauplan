using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerStauplan
{
    class Bay
    {
        public List<Container> ContainerList = new List<Container>() { null, null, null, null };

        public int GetWeight()
        {
            int totalWeight = 0;
            for (int i = 0; i < ContainerList.Count; i++)
            {
                if (ContainerList[i] != null)
                {
                    totalWeight += ContainerList[i].gewicht;
                }
            }
            return totalWeight;
        }

        public void InsertContainer(Container container)
        {
            for (int i = 3; i >= 0; i--)
            {
                if (ContainerList[i] == null)
                {
                    ContainerList[i] = container;
                    break;
                }
            }
        }

        public string GetInfo()
        {
            Cleanup();
            return $"BayGewichte: {ContainerList[0].gewicht} {ContainerList[1].gewicht} {ContainerList[2].gewicht} {ContainerList[3].gewicht}";
        }

        private void Cleanup()
        {
            for (int i = 0; i < 4; i++)
            {
                if (ContainerList[i] == null)
                {
                    ContainerList[i] = new Container(0, 0);
                }
            }
        }
    }
}
