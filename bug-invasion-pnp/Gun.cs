using Godot;
using System;

public partial class Gun : Node2D
{
	// calls bullets and instantiates necessary variables
	[Export] PackedScene RedBulletScene;
	[Export] PackedScene YellowBulletScene;
	[Export] PackedScene GreenBulletScene;
	[Export] PackedScene BlueBulletScene;
	[Export] float dblBulletSpeed = 600;
	[Export] float bps = 4;
	
	float fire_rate;
	
	float time_until_fire = 0f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// makes sure the gunstays at that fire rate
		fire_rate = 1 / bps;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// shoot red bullet input
		if (Input.IsActionJustPressed("ShootRedBullet") && time_until_fire > fire_rate){
			// instantiates bullet
			RigidBody2D RedBullet = RedBulletScene.Instantiate<RigidBody2D>();
			
			// fires from where gun node is
			RedBullet.GlobalPosition = GlobalPosition;
			RedBullet.LinearVelocity = RedBullet.Transform.X * dblBulletSpeed;
			
			// adds bullet to scene
			GetTree().Root.AddChild(RedBullet);
			
			// stops firing
			time_until_fire = 0f;
		}
		// shoot yellow bullet input
		if (Input.IsActionJustPressed("ShootYellowBullet") && time_until_fire > fire_rate){
			// instantiates bullet
			RigidBody2D YellowBullet = YellowBulletScene.Instantiate<RigidBody2D>();
			
			// fires from where gun node is
			YellowBullet.GlobalPosition = GlobalPosition;
			YellowBullet.LinearVelocity = YellowBullet.Transform.X * dblBulletSpeed;
			
			// adds bullet to scene
			GetTree().Root.AddChild(YellowBullet);
			
			// stops firing
			time_until_fire = 0f;
		}
		// shoot green bullet input
		if (Input.IsActionJustPressed("ShootGreenBullet") && time_until_fire > fire_rate){
			// instantiates bullet
			RigidBody2D GreenBullet = GreenBulletScene.Instantiate<RigidBody2D>();
			
			// fires from where gun node is
			GreenBullet.GlobalPosition = GlobalPosition;
			GreenBullet.LinearVelocity = GreenBullet.Transform.X * dblBulletSpeed;
			
			// adds bullet to scene
			GetTree().Root.AddChild(GreenBullet);
			
			// stops firing
			time_until_fire = 0f;
		}
		// shoot blue bullet input
		if (Input.IsActionJustPressed("ShootBlueBullet") && time_until_fire > fire_rate){
			// instantiates bullet
			RigidBody2D BlueBullet = BlueBulletScene.Instantiate<RigidBody2D>();
			
			// fires from where gun node is
			BlueBullet.GlobalPosition = GlobalPosition;
			BlueBullet.LinearVelocity = BlueBullet.Transform.X * dblBulletSpeed;
			
			// adds bullet to scene
			GetTree().Root.AddChild(BlueBullet);
			
			// stops firing
			time_until_fire = 0f;
		}
		else {
			time_until_fire += (float)delta;
		}
	}
}
