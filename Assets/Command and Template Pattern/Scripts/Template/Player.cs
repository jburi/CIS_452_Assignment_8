using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
	public Mesh mesh;
	public string shape;
	public bool particles = false;
	public Transform playerSpawn;
	protected Color color;

	public void CreatePlayer(GameObject player)
	{
		player.transform.position = new Vector3(2, 1.5f, -37);
		GameObject input = GameObject.FindGameObjectWithTag("Input");
		input.GetComponent<PlayerInput>().SetObject(player.GetComponent<MoveObject>());
		input.GetComponent<PlayerInput>().SetCommands();
	}

	public abstract void SetMesh(GameObject player, Mesh mesh);

	public abstract Mesh GetMesh();

	public void SetColor(string thisColor)
	{
		if (thisColor == "red")
		{
			color = Color.red;
		}
		else if (thisColor == "blue")
		{
			color = Color.blue;
		}
		else if (thisColor == "green")
		{
			color = Color.green;
		}
	}
    public virtual void Particles()
	{
		particles = true;
	}

	public Color GetColor()
	{
		return color;
	}
}
