using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScreen : MonoBehaviour
{
    private GameEvents gameEvents;
    [SerializeField] private GameObject loseSceneObject;
    [SerializeField] private GameObject gameplayCanvasObject;
    private void Start()
    {
        gameEvents = GetComponentInParent<GameEvents>();
        gameEvents.OnLose += InitiateLose;
    }

    private void InitiateLose()
    {
        gameplayCanvasObject.SetActive(false);
        loseSceneObject.SetActive(true);
        Time.timeScale = 0;
    }
}
