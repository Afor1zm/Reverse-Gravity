using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EventsInstaller : MonoInstaller
{
    public GameEvents gameEvents;
    public GameObject EventObject;
    public override void InstallBindings()
    {
        Container
            .Bind<GameEvents>()
            .FromComponentOn(EventObject)
            .AsSingle();
    }
}
