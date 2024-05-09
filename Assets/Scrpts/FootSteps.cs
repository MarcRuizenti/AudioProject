using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnStone;

    public string material;

    public void PlayFootstepSound()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);
        myAudioSource.volume = Random.Range(0.8f, 1.0f);

        switch (material)
        {
            case "Grass":
                myAudioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;

            case "Stone":
                myAudioSource.PlayOneShot(footstepsOnStone[Random.Range(0, footstepsOnStone.Length)]);
                break;

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
            case "Stone":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
