using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int frameCounter; //AKA Time.frameCount;
    public Renderer rend;
    void Start()
    {
        frameCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.name +" : "+ frameCounter);
        frameCounter++;
    }
}
