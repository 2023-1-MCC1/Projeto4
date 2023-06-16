using Godot;
using System;

public partial class gameover_4sound : Node2D
{
	AudioStreamPlayer police;
	
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}



private void _on_audio_stream_player_finished()
{
	police = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	police.Play();
}
}
