using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Text mygui;
    int counter = 0, counter2 = 0;
	// Use this for initialization
	void Start () {
        if (Application.isMobilePlatform) mygui.fontSize *= 2;
	}
	
	// Update is called once per frame
	void Update () {
        counter++;
        if(counter% 30 ==0)
        {
            mygui.text = counter2++ + "";
        }
	}

    internal void factCounter(int factor)
    {
        counter2 *= factor;
    }
}
