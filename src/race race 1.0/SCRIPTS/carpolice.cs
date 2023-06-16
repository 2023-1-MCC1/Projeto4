using Godot;
using System;

public partial class carpolice : Area2D
{
	
	public override void _Ready()
	{
	}



private void _on_body_entered(CharacterBody2D body)
{
   GetTree().ChangeSceneToFile("res://SCENES/GAMEOVERS/gameover_4.tscn");
}
}
