using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    private void Awake()
    {
		Time.timeScale = 0;
		DontDestroyOnLoad(transform.gameObject);
	}
    
	public void ToggleGame()
	{ 
		if (!pausePanel.activeInHierarchy) 
        {
            PauseGame();
        }
        if (pausePanel.activeInHierarchy) 
        {
             ContinueGame();   
        }
     }
    private void PauseGame()
    {
        Time.timeScale = 0.001f;
        pausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    } 
    private void ContinueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        //enable the scripts again
    }
}
