using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

    public GameObject ball;
    Color co1;
    int frames;
    Color newCol;
    Parser.Row row;
    Camera camera;

    void Start()
    {
        newCol = Color.red;
        frames = 0;
        camera = GetComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
        row = ball.GetComponent<Parser>().rows[ball.GetComponent<Parser>().counter];
    }

    void Update()
    {
        if (frames % 30 == 0)
        {
        row = ball.GetComponent<Parser>().rows[ball.GetComponent<Parser>().counter];
        ball.GetComponent<Parser>().inc();
        if (!(row.latitude != "" && row.Engine_Speed != "" && row.Odometer_Reading != "" && row.Vehicle_Speed != "")) return;
        newCol = new Color((int)Double.Parse(row.latitude)*3 % 255, (int)Double.Parse(row.Vehicle_Speed)*3 % 255, (int)Double.Parse(row.Engine_Speed)*3 % 255);
            camera.backgroundColor = newCol;    //newCol;
        Debug.Log(row.latitude + "     " + row.Engine_Speed + "     " + row.Vehicle_Speed);
        }
        frames++;
    }
}