using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public float delayBeforeRemoving = 3.0f;

    private void Start()
    {
        var remove = gameObject.AddComponent<RemoveAfterDelay>();
        remove.delay = delayBeforeRemoving;
    }

    private void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
    }
}
