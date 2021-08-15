using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private GameEvents gameEvents;
    [SerializeField] private GameObject pauseCanvas;
    private void Awake()
    {        
        gameEvents = GetComponentInParent<GameEvents>();       
    }
    public void PauseGame()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0f;           
            gameEvents.OnPausedGame();
            pauseCanvas.SetActive(true);
        }            
        else
        {
            Time.timeScale = 1;
            gameEvents.OnProcessGame();
            pauseCanvas.SetActive(false);
        }            
    }
}
