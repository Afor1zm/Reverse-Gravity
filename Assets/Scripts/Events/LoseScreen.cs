using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class LoseScreen : MonoBehaviour
{
    private GameEvents gameEvents;
    [SerializeField] private GameObject loseSceneObject;
    [SerializeField] private GameObject gameplayCanvasObject;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
        gameEvents.OnLose += InitiateLose;
    }

    private void InitiateLose()
    {
        gameplayCanvasObject.SetActive(false);
        loseSceneObject.SetActive(true);
        Time.timeScale = 0;
    }
}
