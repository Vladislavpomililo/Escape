using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Damage : MonoBehaviour
{
    public AudioClip myClip;
    private AudioSource mySource;
 
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

  

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Health>().health -= 49;
            mySource.PlayOneShot(myClip);
        }
    }
}
