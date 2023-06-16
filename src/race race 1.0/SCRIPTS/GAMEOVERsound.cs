using Godot;
using System;

public partial class GAMEOVERsound : Node2D
{
	AudioStreamPlayer fall;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


private void _on_audio_stream_player_finished()
{
	fall = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	fall.Play();
}


}



