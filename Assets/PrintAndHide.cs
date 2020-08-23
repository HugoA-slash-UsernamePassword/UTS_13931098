using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int frameCounter; //AKA Time.frameCount;
    int blueMax;
    public Renderer rend;
    void Start()
    {
        frameCounter = 0;
        blueMax = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.name +" : "+ frameCounter);
        if (gameObject.CompareTag("Red") && frameCounter == 100) gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue") && frameCounter == blueMax) rend.enabled = false;
        frameCounter++;
    }
}
