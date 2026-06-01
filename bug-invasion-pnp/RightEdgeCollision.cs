using Godot;
using System;

public partial class RightEdgeCollision : Area2D
{
	// area RNG initialization
	Random intPotentialArea = new Random();
		
	// right edge handler
	[Signal]
	public delegate void RightEdgeCollidedEventHandler();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{	
		// signal prep for chalice
		BodyEntered += Collision;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	// right edge collision
	public void Collision(Node2D Player){
		// area RNG
		int intArea = intPotentialArea.Next(1, 10);
		// case statement for area
		switch(intArea)
		{
			case 1:
				// goes to GreenLand1
				GetTree().ChangeSceneToFile("res://GreenLand1.tscn");
				break;
			case 2:
				// goes to RedLand1
				GetTree().ChangeSceneToFile("res://RedLand1.tscn");
				break;
			case 3:
				// goes to WhiteLand1
				GetTree().ChangeSceneToFile("res://WhiteLand1.tscn");
				break;
			case 4:
				// goes to GreenLand2
				GetTree().ChangeSceneToFile("res://GreenLand2.tscn");
				break;
			case 5:
				// goes to RedLand2
				GetTree().ChangeSceneToFile("res://RedLand2.tscn");
				break;
			case 6:
				// goes to WhiteLand2
				GetTree().ChangeSceneToFile("res://WhiteLand2.tscn");
				break;
			case 7:
				// goes to GreenLand3
				GetTree().ChangeSceneToFile("res://GreenLand3.tscn");
				break;
			case 8:
				// goes to RedLand3
				GetTree().ChangeSceneToFile("res://RedLand3.tscn");
				break;
			case 9:
				// goes to WhiteLand3
				GetTree().ChangeSceneToFile("res://WhiteLand3.tscn");
				break;
		}
	}
}
