using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    private void Start()
    {
        gameEvents = GetComponentInParent<GameEvents>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerTag trackMove))
        {
            gameEvents.OnScoreCounted();           
        }
    }
}
