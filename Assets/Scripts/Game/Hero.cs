using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    public UnityEvent takeStoneEvent;
    public UnityEvent takeHealthEvent;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<Health>())
            takeHealthEvent?.Invoke();
        if(other.gameObject.GetComponent<Stone>())
            takeStoneEvent?.Invoke();
    }

}
