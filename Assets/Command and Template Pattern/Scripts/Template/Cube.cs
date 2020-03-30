using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Player
{
	private Mesh cubeMesh;

	public override Mesh GetMesh()
	{
		return cubeMesh;
	}
	
	public override void SetMesh(GameObject player, Mesh cube)
	{
		cubeMesh = cube;
		mesh = cube;
		player.GetComponent<MeshFilter>().mesh = mesh;
	}
}
