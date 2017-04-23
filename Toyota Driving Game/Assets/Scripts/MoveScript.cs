using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
    public float velX, velY;
    public bool collide;
    //public GameObject diamond;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(velX, velY, 0));
        //if (transform.position.y <= -16.5) Destroy(gameObject);
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collide && collision.gameObject.tag == "Character") Destroy(gameObject);    
    }
}
