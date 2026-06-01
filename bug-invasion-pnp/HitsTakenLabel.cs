using Godot;
using System;

public partial class HitsTakenLabel : Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AddThemeColorOverride("font_color", Colors.Black);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		// 1. Find the node and cast it to TargetScript
		Player playerScript = GetNode<Player>("../Player");
		
		Text = $"Hits Taken: {playerScript.intHitsTaken}";	
	}
}
