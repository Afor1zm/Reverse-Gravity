using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TrackSpwan : MonoBehaviour
{
    [SerializeField] private GameObject trackPrefab;
    private GameEvents gameEvents;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
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

    private void OnDestroy()
    {
        gameEvents.OnColliderSpawn -= CreateTrackPart;
    }
}
