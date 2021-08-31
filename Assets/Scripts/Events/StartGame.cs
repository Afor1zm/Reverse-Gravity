using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class StartGame : MonoBehaviour
{
    private GameEvents gameEvents;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
    }
    private void Awake()
    {
        Time.timeScale = 0;        
        gameEvents.OnStartGame();
    }

    public void StartingGame()
    {        
        Time.timeScale = 1;
        gameEvents.OnProcessGame();
    }
}
