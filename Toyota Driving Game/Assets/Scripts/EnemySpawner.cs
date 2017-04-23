using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


    public GameObject Diamond;
    public GameObject HPU;
    public GameObject SPU;
    public float  maxPos= 23,  minPos= -23;
    public float delayTimer = 1f;
    float timer;
    // Use this for initialization
    void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Vector3 diamondPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, transform.position.z);
            switch (Random.Range(0, 100))
            {
                case 0:
                    Instantiate(HPU, diamondPos, transform.rotation);
                    break;
                case 1:
                    Instantiate(SPU, diamondPos, transform.rotation);
                    break;
                default:
                    Instantiate(Diamond, diamondPos, transform.rotation);
                    break;
            }
            timer = delayTimer;
        }
    }
}
