using Godot;
using System;


public partial class preto : CharacterBody2D
{
	public const float Speed = 220.0f;
	public const float JumpVelocity = -400.0f;
	 private AnimatedSprite2D _animatedSprite2D;
 public override void _Ready()
   {
		_animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}


	


	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
		  velocity.Y = JumpVelocity;
				
			
			
		  
			

		
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
			_animatedSprite2D.Play("correndo");
	
		
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			_animatedSprite2D.Play("parado");
		}

		Velocity = velocity;
		MoveAndSlide();
	}
	}


