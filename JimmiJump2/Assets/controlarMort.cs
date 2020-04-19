using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using UnityEngine.SceneManagement;

public class controlarMort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void botoRestar(){
       SceneManager.LoadScene("Scenes/Partida");
    }

    public void botoMenu(){
       SceneManager.LoadScene("Scenes/escenaInici");
    }

}
