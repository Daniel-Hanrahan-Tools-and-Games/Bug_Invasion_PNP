using Godot;
using System;

public partial class BlueBullet : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void BlueBulletCollision(Node body){
		
		// 1. calls player script
		Player playerScript = GetNode<Player>("../Player");
		
		if (body.Name == "Player")
		{
			// destroys bullet
			QueueFree();
			
			// sets ball state to 4
			playerScript.intBallState = 4;
		}
		
	}
}
