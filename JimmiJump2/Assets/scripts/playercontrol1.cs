using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class playercontrol1 : MonoBehaviour
{

    public float speed = 2f;
    private Rigidbody2D rb2d;
    public float maxSpeed = 5f;
    private Animator anim;
    public bool suelo=false;

    public float jumpPower = 6.5f;

    private bool jump;
    private bool doubleJump;
    private bool moviment=true;
    private SpriteRenderer spr;
    private GameObject vida;
    private GameObject punts;
    private AudioClip matar;
    AudioSource audioPlayer;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //buscar el player
        anim = GetComponent<Animator>();
        spr=  GetComponent<SpriteRenderer>();
        vida=GameObject.Find("BarraVida");
        punts=GameObject.Find("punts");
        audioPlayer=GetComponent<AudioSource>();

    }//aaa

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("escape")){
                SceneManager.LoadScene("Scenes/escenaInici"); 

        }


 
        if(suelo){
           doubleJump=true;

        }
        anim.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("suelo", suelo);

        if((Input.GetKeyDown(KeyCode.UpArrow))){
           if(suelo==true){
            jump = true;
            doubleJump=true;
           }else if(doubleJump){
                    jump = true;
                    doubleJump=false;
           }
        }

        punts.SendMessage("rebrePunts",transform.position.y);

    }


    private void FixedUpdate() //cada fotograma
    {

        Vector3 fixedVelocity=rb2d.velocity;
        fixedVelocity.x *=0.75f;

        if(suelo){
            rb2d.velocity=fixedVelocity;
        }

        float h = Input.GetAxis("Horizontal");

        if(!moviment){
            h=0;
        }

        rb2d.AddForce(Vector2.right * speed * h);

        float limitSpeed = Mathf.Clamp(rb2d.velocity.x,-maxSpeed,maxSpeed);
        rb2d.velocity = new Vector2(limitSpeed, rb2d.velocity.y); //limitar maxima velocitat


        if(h>0.1f){
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(h < -0.1f){
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }


        if(jump){
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
    }


    void OnBecameInvisible(){  //posicio on apareix si cau
        transform.position=new Vector3(-8,5,0);
    }

    public void enemyKnockBack(float enemyPosX){
        jump=true;
        float lado= Mathf.Sign(enemyPosX - transform.position.x);
        rb2d.AddForce(Vector2.left *lado *jumpPower, ForceMode2D.Impulse);

        moviment=false;
        Invoke("activarMoviment",0.7f);
        spr.color=Color.red;
        vida.SendMessage("daño");

           }

    void activarMoviment(){
        moviment=true;
        spr.color=Color.white;

    }

    void soMatarEnemic(){
        audioPlayer.Play();

    }
}
