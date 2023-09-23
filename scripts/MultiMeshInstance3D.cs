using Godot;
using System;

public partial class MultiMeshInstance3D : Godot.MultiMeshInstance3D
{
	private const int _instances = 10000;

	private readonly Random _rand = new();

	private Transform3D[] _positions = new Transform3D[_instances];

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
	{
		Multimesh.InstanceCount = _instances;
		Multimesh.VisibleInstanceCount = _instances;

		for (int i=0; i < Multimesh.VisibleInstanceCount; i++) {
  		_positions[i] = new Transform3D(Basis.Identity, new Vector3(
				(float)_rand.NextDouble() * 10 - 5, 
				(float)_rand.NextDouble() * 0, 
				(float)_rand.NextDouble() * 10 - 5
			));
  		Multimesh.SetInstanceTransform(i, _positions[i]);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Performance 100'000 boxes with MSAA3D 4x anti-aliasing
		// No cycle: 98 fps
		// Empty cycle: 57 fps
		// Cycle with transform: 26 fps, 10'000 boxes - 165 fps

		Vector3 vec = new();

		for (int i=0; i < Multimesh.VisibleInstanceCount; i++) {
			vec.X = (float)_rand.NextDouble() * .01f - .005f;
			vec.Y = (float)_rand.NextDouble() * .01f - .005f;
			vec.Z = (float)_rand.NextDouble() * .01f - .005f;
  		_positions[i] = _positions[i].Translated(vec);
  		Multimesh.SetInstanceTransform(i, _positions[i]);
		}
	}
}
