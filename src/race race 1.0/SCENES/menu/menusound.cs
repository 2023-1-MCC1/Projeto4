using Godot;
using System;

public partial class menusound : Node2D
{
	AudioStreamPlayer soundtrack;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}



private void _on_audio_stream_player_finished()
{
soundtrack = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	soundtrack.Play();
}
}
