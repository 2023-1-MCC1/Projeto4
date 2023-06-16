using Godot;
using System;

public partial class fase_4_sound : Node2D
{
	AudioStreamPlayer p4;
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
	 p4 = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	p4.Play();
}

}
