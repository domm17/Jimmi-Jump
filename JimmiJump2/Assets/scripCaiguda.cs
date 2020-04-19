using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripCaiguda : MonoBehaviour
{
	public float fallDelay=5f;
	public float respawnDelay=5f;

	private Rigidbody2D rb2d;
	private PolygonCollider2D pc2d;
	private Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
        pc2d= GetComponent<PolygonCollider2D>();
        start= transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
    	if(col.gameObject.CompareTag("Player")){
    		Invoke("fall", fallDelay);
    		Invoke("Respawn", fallDelay+4);
    	}
    }

    void fall(){
    	rb2d.isKinematic=false;
    	pc2d.isTrigger=true; //desectivar colisio contra altres

    }


    void Respawn(){
    	transform.position=start; // posicio es la del prinpici
    	rb2d.isKinematic=true;
    	rb2d.velocity =new Vector3(0f,0f,0f);
    	pc2d.isTrigger=false;
    }
}
