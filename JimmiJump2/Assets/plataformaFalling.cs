using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaFalling : MonoBehaviour
{

	    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {        rb2d = GetComponentInParent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollision2D(Collision2D col){
    	if(col.gameObject.CompareTag("Player")){
    		rb2d.isKinematic=false;
    	}
    }
}
