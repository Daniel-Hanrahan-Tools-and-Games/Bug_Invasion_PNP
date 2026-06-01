using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public int intHitsTaken = 0;
	public int intBallState = 1;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Label HitsTakenLabel = GetNode<Label>("HitsTakenLabel");
		HitsTakenLabel.AddThemeColorOverride("font_color", Colors.Black);
		// 3. Read the variable and update the display text
		HitsTakenLabel.Text = $"Hits Taken: {intHitsTaken}%";	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		
		// Tracks ball on screen
		GlobalPosition = GetGlobalMousePosition();
		
	}
}
