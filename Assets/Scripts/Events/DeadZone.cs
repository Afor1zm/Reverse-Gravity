using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DeadZone : MonoBehaviour
{
    private GameEvents gameEvents;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerTag trackMove))
        {
            gameEvents.OnLose();
        }
    }
}
