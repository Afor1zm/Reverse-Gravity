using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ScoreCounter : MonoBehaviour
{
    private GameEvents gameEvents;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        Debug.Log("LOG");
        gameEvents = gameevents;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerTag trackMove))
        {
            gameEvents.OnScoreCounted();           
        }
    }
}
