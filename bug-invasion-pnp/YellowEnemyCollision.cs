using Godot;
using System;

public partial class YellowEnemyCollision : Area2D
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep
		BodyEntered += YellowCollision;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void YellowCollision(Node body){
		// 1. calls player script
		Player playerScript = GetNode<Player>("../Player");

		// 2. Read player ball state and store it locally
		int intBallState = playerScript.intBallState;	
		
		if (body.Name == "Player")
		{
			if (intBallState == 2)
			{
				// destroys enemy
				QueueFree();
			}
			else
			{
				playerScript.intHitsTaken += 1;
			}
		}
		
	}
	
	
}
