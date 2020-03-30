using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Player
{
	private Mesh sphereMesh;
	private ParticleSystem particleEffects;

	public override Mesh GetMesh()
	{
		return sphereMesh;
	}

	public override void SetMesh(GameObject player, Mesh sphere)
	{
		sphereMesh = sphere;
		mesh = sphere;
		player.GetComponent<MeshFilter>().mesh = mesh;
	}
	//Has particle hook
	public override void Particles()
	{

			particleEffects = GameObject.Find("Particle System").GetComponent<ParticleSystem>();
			StartCoroutine(Transform());
			particleEffects.Play();
	}

	public IEnumerator Transform()
	{
		while(particleEffects.isPlaying)
		{
			gameObject.transform.parent = particleEffects.transform;
		}
		yield return new WaitForSeconds(1);
	}
}
