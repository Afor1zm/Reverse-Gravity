using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameSettings : MonoBehaviour
{
    private GameEvents gameEvents;
    [SerializeField] private GameObject pauseCanvas;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
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
