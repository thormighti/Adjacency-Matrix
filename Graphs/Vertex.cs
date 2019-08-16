using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Vertex
    {
        public int label;
        public bool wasVisited;
        public Vertex(int label)
        {
            this.label = label;
            this.wasVisited = false;    
        }
    }
}
