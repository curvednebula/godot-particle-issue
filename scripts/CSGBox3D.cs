using Godot;
using System;

public partial class CSGBox3D : CsgBox3D
{
	private readonly Random rand = new();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Rotate(new Vector3(1, 0, 0), rand.Next());
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Rotate(new Vector3(1, 0, 0), 2f * (float)delta);
	}
}
