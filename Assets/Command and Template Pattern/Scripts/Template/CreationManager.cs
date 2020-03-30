using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreationManager : MonoBehaviour
{
	[SerializeField]
	public string color = "red";
	public string shape = "cube";
	public Mesh cube;
	public Mesh capsule;
	public Mesh sphere;
	public GameObject player;
	public ParticleSystem particleEffect;
	public bool particle = false;

	private void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
		particleEffect.Stop();
	}
	public void PreparePlayer()
	{
		if (shape == "cube")
		{
			player = GameObject.CreatePrimitive(PrimitiveType.Cube); 
			player.AddComponent<Cube>();
			PlayerSimilaities();
			var renderer = player.GetComponent<MeshRenderer>();
			player.GetComponent<Cube>().SetMesh(player, cube);
			player.GetComponent<Cube>().SetColor(color);
			Color theColor = player.GetComponent<Cube>().GetColor();
			renderer.material.SetColor("_Color", theColor);
			player.GetComponent<Cube>().CreatePlayer(player);
		}
		else if (shape == "capsule")
		{
			player = GameObject.CreatePrimitive(PrimitiveType.Capsule); 
			player.AddComponent<Capsule>();
			PlayerSimilaities();
			var renderer = player.GetComponent<MeshRenderer>();
			player.GetComponent<Capsule>().SetMesh(player, capsule);
			player.GetComponent<Capsule>().SetColor(color);
			Color theColor = player.GetComponent<Capsule>().GetColor();
			renderer.material.SetColor("_Color", theColor);
			player.GetComponent<Capsule>().CreatePlayer(player); 
		}
		else if (shape == "sphere")
		{
			player = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
			player.AddComponent<Sphere>();
			PlayerSimilaities();
			var renderer = player.GetComponent<MeshRenderer>();
			player.GetComponent<Sphere>().SetMesh(player, sphere);
			player.GetComponent<Sphere>().SetColor(color);
			Color theColor = player.GetComponent<Sphere>().GetColor();
			renderer.material.SetColor("_Color", theColor);
			player.GetComponent<Sphere>().Particles();
			player.GetComponent<Sphere>().CreatePlayer(player); 
		} 
	}

	public void PlayerSimilaities()
	{
		player.name = "Player";
		player.tag = "Player";
		player.AddComponent<Rigidbody>();
		Rigidbody m_Rigidbody = player.GetComponent<Rigidbody>();
		m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
		player.GetComponent<Rigidbody>().useGravity = true;
		player.GetComponent<Rigidbody>();
		player.AddComponent<MoveObject>();
	}
	
	public void SetColor(string thisColor)
	{
		color = thisColor;
	}
	public void SetParticles()
	{
		particle = true;
	}
	public void SetMesh(string thisShape)
	{
		shape = thisShape;
	}
}
