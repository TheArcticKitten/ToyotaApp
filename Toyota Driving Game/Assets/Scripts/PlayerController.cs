using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private int health;
    public float startHealth;
    public float speed;
    public bool inMenu;
    public Texture2D img;
    private float xBound, yBound;
    Vector3 position;
	// Use this for initialization
	void Start () {
        xBound = 30.3f;
        yBound = 15.5f;
        health = (int)startHealth;
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(gameObject);
            return;
        }
        position.x += Input.GetAxis("Horizontal") * speed;
        if (position.x >= xBound) position.x = xBound;
        if (position.x <= -xBound) position.x = -xBound;
        if (position.y >= yBound) position.y = yBound;
        if (position.y <= -yBound) position.y = -yBound;

        position.y += Input.GetAxis("Vertical") * speed;
        transform.position = position;
	}

    void OnGUI()
    {
        for (int i = 0; i < health; i++)
        {
            Rect oRect = new Rect(54*i, 1020, 50, 50);
            GUI.DrawTexture(oRect, img);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!inMenu && collision.gameObject.tag == "RedDiamond") health--;
        else if (!inMenu && collision.gameObject.tag == "HPU" && health <= 4) health++;
    }
}
