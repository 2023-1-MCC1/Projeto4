using Godot;
using System;

public partial class chegada2 : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}





private void _on_body_entered(CharacterBody2D body)
{
	GetTree().ChangeSceneToFile("res://SCENES/fases/fase_3.tscn");
}
}
