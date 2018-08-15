using System;
using Xunit;
using Shouldly;
using Bontecou_Model = Bontecou.Model;

namespace Bontecou.Tests.Unit.Model.World
{
	[Trait("DisplayName", "Model.World")]
    public class WorldTests
    {
		private readonly string _worldName;
		private readonly Bontecou_Model.World _world;

		public WorldTests()
		{
			_worldName = "Test World";
			_world = new Bontecou_Model.World(_worldName);
		}
		[Fact(DisplayName = "Can be created.")]
		public void CanBeCreated()
		{
			_world.ShouldNotBeNull();
		}

		[Fact(DisplayName = "Has valid name.")]
		public void HasValidName()
		{
			_world.Name.ShouldNotBeNullOrEmpty();
			_world.Name.ShouldBe(_worldName);
		}

		[Fact(DisplayName = "Has valid extents.")]
		public void HasValidExtents()
		{
			_world.Extents.ShouldNotBeNull();
			_world.Extents.North.ShouldBe(1.0);
			_world.Extents.East.ShouldBe(1.0);
			_world.Extents.South.ShouldBe(-1.0);
			_world.Extents.West.ShouldBe(-1.0);
		}

		[Fact(DisplayName = "Has an empty 'Actors' collection.")]
		public void HasActorsCollection()
		{
			_world.Actors.ShouldNotBeNull();
			_world.Actors.ShouldBeEmpty();
		}
    }
}
