using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JsonParse
{
    internal class ItemResponse
    {

        private string locale;
        private string description;
        private BoundingPoly boundingPoly;

        public string Locale
        {
            get { return locale; }
            set { locale = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public BoundingPoly BoundingPoly
        {
            get { return boundingPoly; }
            set { boundingPoly = value; }
        }

    }


    public class BoundingPoly
    {
        private List<Vertices> vertices;

        public List<Vertices> Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }
    }

    public class Vertices
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
