using Godot;
using System;

public partial class CHEGADA3 : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}



private void _on_body_entered(CharacterBody2D body)
{
	GetTree().ChangeSceneToFile("res://SCENES/fases/fase_4.tscn");
}
}
