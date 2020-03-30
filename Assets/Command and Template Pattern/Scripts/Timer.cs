﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	float timeLeft = 20f;
	public Text text_box;
	
    // Update is called once per frame
    void Update()
    {
		timeLeft -= Time.deltaTime;
		text_box.text = timeLeft.ToString("0.00");
	}
}

