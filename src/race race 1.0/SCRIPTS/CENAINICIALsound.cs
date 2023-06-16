using Godot;
using System;

public partial class CENAINICIALsound : Node2D
{
	AudioStreamPlayer p1;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
private void _on_audio_stream_player_finished()
{
 p1 = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	p1.Play();
}

}

