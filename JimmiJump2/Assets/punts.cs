using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class punts : MonoBehaviour
{
	public Text altura;
	public string puntuacio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	altura.text=puntuacio;
        
    }

    public void rebrePunts(float x){

    		if(x>= 102){
				SceneManager.LoadScene("Scenes/Win"); 
    		}
			int y= (int) x+2;
			puntuacio=y.ToString();
    }
}
