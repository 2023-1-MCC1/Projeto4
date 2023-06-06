using Godot;
using System;

public partial class Timer : Godot.Timer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}



private void _on_timeout()
{
	GetTree().ChangeSceneToFile("res://SCENES/GAMEOVERS/GAMEOVERTEMPO.tscn");
}
}
