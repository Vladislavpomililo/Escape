using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Audiocontroller : MonoBehaviour
{

    public AudioClip[] myClip;
    

    private AudioSource mySource;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
        StartCoroutine(audiomenu());
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator audiomenu()
    {
        while (true)
        {
            mySource.PlayOneShot(myClip[Random.Range(0,2)]);
            yield return new WaitForSeconds(20f);
        }
    }
}
