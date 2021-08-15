using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public Action OnStartGame = delegate { Debug.Log($"Game Started"); };
    public Action OnLose = delegate { Debug.Log($"Game Ended"); };
    public Action OnScoreCounted = delegate { Debug.Log($"Score collected"); };
    public Action OnPausedGame = delegate { Debug.Log($"Game paused"); };
    public Action OnProcessGame = delegate { Debug.Log($"Game resumed"); };
    public Action OnGravityChanged = delegate { Debug.Log($"Gravity changed"); };
    public Action OnColliderSpawn = delegate { Debug.Log($"New Track part spawned"); };
    public Action OnColliderDestroy = delegate { Debug.Log($"Track Destroyed"); };
}
