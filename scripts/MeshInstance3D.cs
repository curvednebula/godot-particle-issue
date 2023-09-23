using Godot;
using System;

public partial class Mesh3D : MeshInstance3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var mesh = new ArrayMesh();
		
		// Define arrays for vertices and colors
		Vector3[] vertices = {
				new(0, 0, 0),
				new(100, 0, 0),
				new(0, 100, 0)
		};
		Color[] colors = {
				new(1, 0, 0),
				new(0, 1, 0),
				new(0, 0, 1)
		};
		
		// Convert arrays to Godot's Arrays type
		var arrays = new Godot.Collections.Array
		{
			[(int)ArrayMesh.ArrayType.Vertex] = vertices,
			[(int)ArrayMesh.ArrayType.Color] = colors
		};
		
		// Add arrays to ArrayMesh
		mesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, arrays);
		
		// Assign mesh to MeshInstance
		this.Mesh = mesh;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
