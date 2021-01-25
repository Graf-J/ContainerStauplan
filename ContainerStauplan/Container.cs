using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerStauplan
{
    class Container
    {
        public int nr { get; set; }
        public int gewicht { get; set; }

        public Container(int nr, int gewicht)
        {
            this.nr = nr;
            this.gewicht = gewicht;
        }
    }
}
