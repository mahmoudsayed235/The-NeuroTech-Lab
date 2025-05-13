using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerController : MonoBehaviour
{
    public string triggeringTag = "Player";
    
    public UnityEvent onTriggerEntered;

    private void OnTriggerEnter(Collider other)
    {
        if (string.IsNullOrEmpty(triggeringTag) || other.CompareTag(triggeringTag))
        {
            onTriggerEntered?.Invoke();
        }
    }
}
