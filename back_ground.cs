using Godot;
using System;

public partial class back_ground : ParallaxBackground
{
	public float scrollingSpeed = 100;

	public override void _Process(double delta){
		Vector2 so = ScrollOffset;
		so.X -= scrollingSpeed * (float)delta;
		ScrollOffset = so;
	}
}
