using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracPartDetection : MonoBehaviour
{
    private GameEvents gameEvents;
    private void Start()
    {
        gameEvents = GetComponentInParent<GameEvents>();
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
