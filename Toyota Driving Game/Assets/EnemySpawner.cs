using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


    public GameObject Diamond;
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
            Instantiate(Diamond, diamondPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
