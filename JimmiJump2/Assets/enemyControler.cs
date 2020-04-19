using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControler : MonoBehaviour
{

	public float speed = 1f;
    public float maxSpeed = 1f;
    private Rigidbody2D rb2d;
    private AudioClip matar;
    AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>(); //buscar el player
        audioPlayer=GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void FixedUpdate()//cada framerate
    {
        
       rb2d.AddForce(Vector2.right * speed);
        float limitSpeed = Mathf.Clamp(rb2d.velocity.x,-maxSpeed,maxSpeed);
        rb2d.velocity = new Vector2(limitSpeed, rb2d.velocity.y); //limitar maxima velocitat

        if(rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f){
        	speed=-speed;
        	rb2d.velocity = new Vector2(speed, rb2d.velocity.y); //limitar maxima velocitat

        }


        if(speed<0f){
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(speed > 0f){
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }


    }


    void OnTriggerEnter2D(Collider2D col){
        bool destruir=false;
    	if(col.gameObject.tag == "Player"){
			if(transform.position.y+0.5 < col.transform.position.y){
             col.SendMessage("soMatarEnemic"); //comunicacio entre scripts
            
            Destroy(gameObject); 


			}else{

				col.SendMessage("enemyKnockBack", transform.position.x); //comunicacio entre scripts
			}

		}
    }


      

}
