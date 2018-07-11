using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using Bontecou.Model;

namespace Bontecou.Tests.Unit
{
    public class WorldTests
    {
		[Fact(DisplayName = "Can be created.")]
		public void WorldCanBeCreated()
		{
			var world = new World();
			world.ShouldNotBeNull();
		}
    }
}
