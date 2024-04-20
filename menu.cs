using Godot;
using System;

public partial class menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	// 
	private void _on_level1_pressed()
	{
		// Replace with function body.
		GetTree().ChangeSceneToFile("res://level/level.tscn");
	}
	//
	private void _on_level2_pressed()
	{
		// Replace with function body.

	}
	private void _on_level_2_pressed()
	{
		GetTree().ChangeSceneToFile("res://level2/level.tscn");
	}
	private void _on_exit_pressed()
	{
		// Replace with function body.
		GD.Print("Exit button");
		GetTree().Quit();
	}

}



