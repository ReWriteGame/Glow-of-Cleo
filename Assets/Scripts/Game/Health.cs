using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityEvent getHeroEvent;
    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.GetComponent<Hero>())
           getHeroEvent?.Invoke();
    }


}
