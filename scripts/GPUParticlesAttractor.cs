using Godot;
using System;

public partial class GPUParticlesAttractor : GpuParticlesAttractorSphere3D
{
	private float _angle = 0.0f; 

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_angle += (float)delta * 5f;
		Position = new Vector3(-1, 0.5f, -1 + Mathf.Cos(_angle) * 2);
	}
}
