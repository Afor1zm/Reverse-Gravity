using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSpwan : MonoBehaviour
{
    [SerializeField] private GameObject trackPrefab;
    [SerializeField] private GameEvents gameEvents;

    private void Awake()
    {
        gameEvents = GetComponentInParent<GameEvents>();
    }
    void Start()
    {        
        CreateTrackPart();
        gameEvents.OnColliderSpawn += CreateTrackPart;
    }

    private void CreateTrackPart()
    {
        Instantiate(trackPrefab, transform);
    }
}
