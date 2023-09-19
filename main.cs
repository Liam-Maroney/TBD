using Godot;
using System;

public partial class main : Node2D
{
	private void _on_quit_pressed()
	{
		GetTree().Quit();
	}
}
