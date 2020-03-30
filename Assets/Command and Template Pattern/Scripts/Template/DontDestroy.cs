using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	private void Start()
	{
		Time.timeScale = 0;
		DontDestroyOnLoad(transform.gameObject);
	}
}
