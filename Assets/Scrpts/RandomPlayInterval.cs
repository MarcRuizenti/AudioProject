using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class RandomPlayInterval : MonoBehaviour
{
    [SerializeField] private AudioClip[] sounds;
    private float timerCounter;
    [SerializeField] private float minNum; 
    [SerializeField] private float maxNum;
    AudioSource myAudioSource;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        timerCounter = Random.Range(minNum, maxNum);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerCounter <= 0) 
        {
            int num = Random.Range(0, sounds.Length);
            AudioClip sound = sounds[num];
            myAudioSource.PlayOneShot(sound);
            timerCounter = Random.Range(minNum, maxNum) + sound.length;
            
        }
        else
        {
            timerCounter -= Time.deltaTime;
        }
    }
}
