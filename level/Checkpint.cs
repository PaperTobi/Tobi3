using Godot;
using System;

public class Checkpoint : Node2D
{
	[Export]
	public string NextScenePath;

	private Area2D _area2d;

	public override void _Ready()
	{
		_area2d = GetNode<Area2D>("Area2D");
		_area2d.Connect("body_entered", this, nameof(OnBodyEntered));
	}

	private void OnBodyEntered(Node body)
	{
		if (body is Player)
		{
			GetTree().ChangeSceneToFile("res://level/complete.tscn");
		}
	}
}
