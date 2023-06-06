using Godot;
using System;

public partial class fallzone : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}



private void _on_body_entered(CharacterBody2D body)
{
  GetTree().ChangeSceneToFile("res://SCENES/GAMEOVERS/GAMEOVER.tscn");
}
}
