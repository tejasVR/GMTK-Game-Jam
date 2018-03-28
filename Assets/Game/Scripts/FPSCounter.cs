using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour {

    //public TextMesh text;
    private string textFPS;
    float fps;
    float frameCount;
    float deltaTime;
    private string textRotation;

	// Use this for initialization
	void Start () {

        //text = GetComponent<TextMesh>();
		
	}
	
	// Update is called once per frame
	void Update () {

        /*

        frameCount++;
        deltaTime += Time.deltaTime;
        if (deltaTime > 1f/4)
        {
            fps = frameCount / deltaTime;
            frameCount = 0;
            deltaTime -= 1f/4f;
        }
        */

        textFPS = fps.ToString();
        textRotation = WorldManager.Instance.headRotate.ToString();

        //GetComponent<TextMesh>().text = "" + textFPS;

        GetComponent<TextMesh>().text = "Head Rotation = " + textRotation;

	}
}
