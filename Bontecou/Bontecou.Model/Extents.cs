using System;
using System.Collections.Generic;
using System.Text;

namespace Bontecou.Model
{
    public class Extents
    {
		public double North { get; set; }
		public double East { get; set; }
		public double South { get; set; }
		public double West { get; set; }

		public Extents() : this(1.0, 1.0, -1.0, -1.0)
		{}
		public Extents(double north, double east, double south, double west)
		{
			this.North = north;
			this.East = east;
			this.South = south;
			this.West = west;
		}
    }
}
