using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ReversingGravity : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float gravityMultiplicator;
    private void Awake()
    {
        Physics.gravity = gravityMultiplicator * Vector3.down * 9.8f;
    }
    private void ChangeGravity()
    {
        Physics.gravity *= -1;
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        ChangeGravity();
    }
}
