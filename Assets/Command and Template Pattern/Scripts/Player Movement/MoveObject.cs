using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveObject : MonoBehaviour
{
	private Stack<Vector3> positionHistory = new Stack<Vector3>();

	public Vector3 GetCurrentPosition()
	{
		return gameObject.transform.position;
	}

	public Stack<Vector3> GetHistory()
	{
		return positionHistory;
	}
	public void MoveForward()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * 8);
	}
	public void MoveLeft()
	{
		transform.Translate(Vector3.left * Time.deltaTime * 8);
	}
	public void MoveRight()
	{
		transform.Translate(Vector3.right * Time.deltaTime * 8);
	}
	public void MoveDown()
	{
		transform.Translate(Vector3.back * Time.deltaTime * 8);
	}
}