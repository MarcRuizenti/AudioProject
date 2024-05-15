using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnviromentChange : MonoBehaviour
{
    public AudioMixerSnapshot outdoorSnapshot;
    public AudioMixerSnapshot indoorSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Indoor")
            indoorSnapshot.TransitionTo(0.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Indoor")
            outdoorSnapshot.TransitionTo(0.5f);
    }
}
