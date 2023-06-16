using Godot;
using System;

public partial class win_audio : Node2D
{
	AudioStreamPlayer win;
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
	win = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	win.Play();
}

}

