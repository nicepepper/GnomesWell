using System;
using UnityEngine.Events;
using UnityEngine;

public class Resettable : MonoBehaviour
{
    public UnityEvent onReset;

    public void Reset()
    {
        onReset.Invoke();
    }
}
