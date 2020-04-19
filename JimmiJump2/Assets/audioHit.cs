using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioHit : MonoBehaviour
{
	private AudioClip sorollCop;
	AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reproduirHit(){
    	audioSource.PlayOneShot(sorollCop);
    }
}
