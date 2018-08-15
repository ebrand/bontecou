using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Bontecou.Model
{
    public class World
    {
		public string Name;
		public Extents Extents;
		public List<Actor> Actors;

		public World(string name)
		{
			this.Name = name;
			this.Extents = new Extents();
			this.Actors = new List<Actor>();
		}
    }
}
