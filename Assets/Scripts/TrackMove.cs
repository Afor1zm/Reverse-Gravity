using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{    
    [SerializeField] private float movementSpeed;
    private Vector3 translateVector;
    private void Update()
    {
        translateVector = Vector3.left * movementSpeed * Time.deltaTime;
        gameObject.transform.Translate(translateVector);
    }
}
