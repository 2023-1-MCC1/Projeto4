using Godot;
using System;

public partial class retornaraomenu : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}


private void _on_pressed()
{
GetTree().ChangeSceneToFile("res://SCENES/menu/menu.tscn");
}
}
