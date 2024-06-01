using Godot;
using System;

public partial class level1menu : VBoxContainer
{
	private void _on_retry_pressed()
	{
		GetTree().ChangeSceneToFile("res://level/level.tscn");
	}


	private void _on_next_level_pressed()
	{
		GetTree().ChangeSceneToFile("res://level2/level.tscn");
	}


	private void _on_menu_pressed()
	{
		GetTree().ChangeSceneToFile("res://menu/menu.tscn");
	}
}



