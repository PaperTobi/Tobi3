using Godot;
using System;

public partial class menu : Control
{
	private void _on_level1_pressed()
	{
		GetTree().ChangeSceneToFile("res://level/level.tscn");
	}
	private void _on_level_2_pressed()
	{
		GetTree().ChangeSceneToFile("res://level2/level.tscn");
	}
	private void _on_exit_pressed()
	{
		GetTree().Quit();
	}

}
