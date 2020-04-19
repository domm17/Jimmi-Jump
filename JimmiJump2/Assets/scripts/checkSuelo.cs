using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkSuelo : MonoBehaviour {

    private playercontrol1 player;

    private Rigidbody2D rb2d;
    // Use this for initialization
	void Start () {
        player = GetComponentInParent<playercontrol1>();
        rb2d = GetComponentInParent<Rigidbody2D>();

	}

    private void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject.tag == "suelo"){
            player.suelo = true;
            //saaa
        }

        if (col.gameObject.tag == "platform"){
            player.transform.parent = col.transform;
            player.suelo = true;
            //saaa
        }


    }

    private void OnCollisionExit2D(Collision2D col)
    {

        if (col.gameObject.tag == "suelo"){
            player.suelo = false;
            }

        if (col.gameObject.tag == "platform"){
            player.transform.parent = null;
            player.suelo = false;
            }


    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "platform"){
            rb2d.velocity= new Vector3(0f,0f,0f);
            player.transform.parent = col.transform;
            player.suelo = true;
            //saaa
        }

    }
    // Update is called once per frame
    void Update () {
    }
}
