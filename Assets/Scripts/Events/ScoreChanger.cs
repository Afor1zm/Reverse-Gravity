using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;

public class ScoreChanger : MonoBehaviour
{
    private GameEvents gameEvents;
    private int score =0;
    private TextMeshProUGUI textComponent;

    [Inject]
    private void Construct(GameEvents gameevents)
    {
        gameEvents = gameevents;
    }
    void Start()
    {        
        gameEvents.OnScoreCounted += PitJumped;
        gameEvents.OnLose += EndSubscribes;        
        textComponent = gameObject.GetComponent<TextMeshProUGUI>();        
    } 
    private void PitJumped()
    {
        score++;
        textComponent.text = $"Score: {score}";
    }
    private void EndSubscribes()
    {
        gameEvents.OnScoreCounted -= PitJumped;
        gameEvents.OnLose -= EndSubscribes;
    }
}
