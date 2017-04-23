using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        xBound = 28.6f;
        yBound = 15.5f;
        health = (int)startHealth;
        position = transform.position;
        if (Application.isMobilePlatform) speed *= 6;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(gameObject);
            return;
        }
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            position.x += Input.GetAxis("Horizontal") * speed;
            position.y += Input.GetAxis("Vertical") * speed;
            if (position.x >= xBound) position.x = xBound;
            if (position.x <= -xBound) position.x = -xBound;
            if (position.y >= yBound) position.y = yBound;
            if (position.y <= -yBound) position.y = -yBound;
            transform.position = position;
        }
        else if(Application.isMobilePlatform)
        {
            Touch first = Input.GetTouch(0);
          //  if (first.phase == TouchPhase.Stationary || first.phase == TouchPhase.Moved)
            //{
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(first.position.x, first.position.y, 10));
                transform.position = Vector3.Lerp(transform.position, touchPosition, Time.smoothDeltaTime);
            //}
        }
      /*  if (position.x >= xBound) position.x = xBound;
        if (position.x <= -xBound) position.x = -xBound;
        if (position.y >= yBound) position.y = yBound;
        if (position.y <= -yBound) position.y = -yBound;
        transform.position = position;*/


    }

    void OnGUI()
    {
        if (inMenu) return;
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
        else if (inMenu && collision.gameObject.tag == "DS1") Application.LoadLevel(1);
    }
}
