using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Player
{
	private Mesh capsuleMesh;

	public override Mesh GetMesh()
	{
		return capsuleMesh;
	}

	public override void SetMesh(GameObject player, Mesh capsule)
	{
		capsuleMesh = capsule;
		mesh = capsule;
		player.GetComponent<MeshFilter>().mesh = mesh;		
	}
}
