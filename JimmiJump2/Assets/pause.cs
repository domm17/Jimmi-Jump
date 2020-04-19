using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
	bool active;
	Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas= GetComponent<Canvas>();
        canvas.enabled=false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
        	active=!active;
        	canvas.enabled=active;
        	if(active){
        		Time.timeScale= 0;
        	}else{
        		    Time.timeScale= 1;

        	}

        }
    }
}
