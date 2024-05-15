using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChangeMusic : MonoBehaviour
{
    public AudioMixerSnapshot baseSnapshot;
    public AudioMixerSnapshot calmSnapshot;
    public AudioMixerSnapshot combatSnapshot;

    public float fastTransition = 0.5f;
    public float slowTransition = 4.0f;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "tension":
                combatSnapshot.TransitionTo(fastTransition);
                break;

            case "Indoor":
                calmSnapshot.TransitionTo(slowTransition);
                break;

            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "tension":
                baseSnapshot.TransitionTo(slowTransition);
                break;

            case "Indoor":
                baseSnapshot.TransitionTo(slowTransition);
                break;

            default:
                break;
        }
    }
}
