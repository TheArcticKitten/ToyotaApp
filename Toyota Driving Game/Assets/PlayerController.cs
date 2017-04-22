using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private int health;
    public float startHealth;
    public float speed;
    Vector3 position;
	// Use this for initialization
	void Start () {
        health = (int)startHealth;
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * speed;
        position.y += Input.GetAxis("Vertical") * speed;
        transform.position = position;
	}
}
