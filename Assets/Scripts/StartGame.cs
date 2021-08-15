using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private GameEvents gameEvents;  
    private void Awake()
    {
        Time.timeScale = 0;
        gameEvents = GetComponentInParent<GameEvents>();
        gameEvents.OnStartGame();
    }

    public void StartingGame()
    {        
        Time.timeScale = 1;
        gameEvents.OnProcessGame();
    }
}
