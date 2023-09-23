using Godot;
using System;

public partial class MainScene : Node3D
{
	private PackedScene boxScene = GD.Load<PackedScene>("res://scenes/box.tscn");
	private Vector3 rotateVec = new(1, 0, 0);
	private Godot.Collections.Array<Node> nodes;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// float radius = 5.0f;
		// float toAngle =  MathF.PI * 200;
		// int numItems = 100000;

		// for (float a = 0; a < toAngle; a += toAngle / numItems) {
		// 	Node3D box = boxScene.Instantiate<Node3D>();
		// 	box.Translate(new Vector3(Mathf.Sin(a) * radius, a * 0.2f, Mathf.Cos(a) * radius));
		// 	box.Scale = new Vector3(0.1f, 0.1f, 0.1f);
    // 	AddChild(box);
		// }
		// nodes = GetChildren();

		// foreach (var node in nodes) {
		// 	var node3d = (Node3D)node;
		// 	node3d.Rotate(rotateVec, new Random().Next());
		// }
	}

	public override void _Process(double delta)
	{
		// NOTE: moving box rotation from each box to central place increased FPS in debug mode from 20 to 50
		// moving new Vector() and GetChildren() out of _Process - only added +2 fps
		// foreach (var node in nodes) {
		// 	var node3d = (Node3D)node;
		// 	node3d.Rotate(rotateVec, 2 * (float)delta);
		// }
	}
}
