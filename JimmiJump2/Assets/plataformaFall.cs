using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaFall : MonoBehaviour
{

	private Rigidbody2D rb2d;

	public float fallDelay=1f;
	public float respawnDelay=1f;
	private Vector3 start;

    // Start is called before the first frame update
    void Start()
    {        

    	rb2d = GetComponent<Rigidbody2D>();
    	start= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D col){
    	if(col.gameObject.CompareTag("Player")){
    			Invoke("fall", fallDelay);
    			Invoke("respawn", fallDelay+respawnDelay);

    	}
    }

    void fall(){
    	    rb2d.isKinematic=false;

    }

    void respawn(){
    	transform.position=start;
    	rb2d.isKinematic=true;
    	rb2d.velocity= Vector3.zero;

    }
}
