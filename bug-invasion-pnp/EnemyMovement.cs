using Godot;
using System;

public partial class EnemyMovement : PathFollow2D
{
	// declare movespeed
	public float dblMoveSpeed = 0.1f;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Conversion Needed for progress ratio
		float MyDelta = (float)delta;
		
		// moves enemy along the path
		ProgressRatio += MyDelta * dblMoveSpeed;
	}
}
