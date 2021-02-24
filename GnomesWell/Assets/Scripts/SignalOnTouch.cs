using System;
using UnityEngine.Events;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class SignalOnTouch : MonoBehaviour
{
    public UnityEvent onTouch;
    public bool playAudioOnTouch = true;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        SendSignal(collider2D.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collider2D)
    {
        SendSignal(collider2D.gameObject);
    }

    void SendSignal(GameObject objectThatHit)
    {
        if (objectThatHit.CompareTag("Player"))
        {
            if (playAudioOnTouch)
            {
                var audio = GetComponent<AudioSource>();
                if (audio && audio.gameObject.activeInHierarchy)
                {
                    audio.Play();
                }
            }
            onTouch.Invoke();
        }
    }
}
