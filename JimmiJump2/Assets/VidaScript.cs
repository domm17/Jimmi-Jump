using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaScript : MonoBehaviour
{
	float vida=100f;
	float maxVida=100f;

	public Image imageVida;
	private AudioClip sorollCop;
	AudioSource audioPlayer;


    // Start is called before the first frame update
    void Start()
    {
        vida=maxVida;
        audioPlayer=GetComponent<AudioSource>();
		
    }


	public void daño(){
		vida=vida-10;
		imageVida.transform.localScale= new Vector2(vida/maxVida,1);

		audioPlayer.Play();

		if(vida<10){
			 SceneManager.LoadScene("Scenes/Dead");

		}
	}

}
