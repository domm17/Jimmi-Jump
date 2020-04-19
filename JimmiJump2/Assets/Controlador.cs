using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     public void iniciPartida(){
    		SceneManager.LoadScene("Scenes/Partida");
    }

        public void sortirJoc(){
			Application.Quit();
	}

         public void instruccions(){
            SceneManager.LoadScene("Scenes/instructions");
    }


}
