using Godot;
using System;

public partial class OmniLight : OmniLight3D
{
	private float _angle = 0;
	private float _radius = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// _angle += (float)delta * 5f;
		// // _radius = 2 + Mathf.Sin(_angle * 2) * 2;

		// Position = new Vector3(Mathf.Sin(_angle) * _radius, 0, Mathf.Cos(_angle) * _radius);
		// Rotation = new Vector3(0, _angle, 0);
	}
}
