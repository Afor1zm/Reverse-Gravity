using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TracPartDetection : MonoBehaviour
{
    private GameEvents gameEvents;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out TrackMove trackMove))
        {
            gameEvents.OnColliderSpawn();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        gameEvents.OnColliderDestroy();
    }
}
