using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

    public Color altColor = Color.black;
    public Renderer rend;

    void Start()
    {
        //Get the renderer of the object so we can access the color
        rend = GetComponent<Renderer>();
        //Set the initial color (0f,0f,0f,0f)
        rend.material.color = altColor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //Alter the color          
            altColor.g += 0.1f;
            //Assign the changed color to the material.
            rend.material.color = altColor;
        }
    }
}