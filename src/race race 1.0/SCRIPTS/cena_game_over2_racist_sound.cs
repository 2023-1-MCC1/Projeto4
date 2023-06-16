using Godot;
using System;

public partial class cena_game_over2_racist_sound : Node2D
{
	AudioStreamPlayer racist;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


private void _on_audio_stream_player_finished()
{
	racist = this.GetNode<AudioStreamPlayer>("AudioStreamPlayer");
	racist.Play();
}
}


