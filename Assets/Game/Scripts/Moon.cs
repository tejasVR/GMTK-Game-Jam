using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour {

    public Quaternion startRotation;
    public Quaternion targetRotation;

    public Vector3 startPosition;
    public Vector3 targetPosition;

    public Light light;

    public float yRotation;

    public float tiltAngleY = 30f;

    private Color colorSolid;
    private Color colorFade;

    private float TimeToFade = 1.0f;

    public Renderer rend;


	// Use this for initialization
	void Start () {

        //startRotation = Quaternion.Euler(-8.4f, -3.7f, -71.4f);

        //targetRotation = Quaternion.Euler(7.7f, 1.7f, -71.4f);

        startPosition = transform.position;
        //targetPosition = new Vector3(-74f, 63f, 611f);
        rend = GetComponent<Renderer>();

        //colorSolid = GetComponent<MeshRenderer>().material.color;
        //colorFade = GetComponent<MeshRenderer>().material.color;

        //colorSolid.a = 1;
        //colorFade.a = 0;




        //targetRotation = Quaternion

        light = GetComponent<Light>();
		
	}
	
	// Update is called once per frame
	void Update () {



        //targetRotation = Quaternion.Euler(0, tiltAngleY * WorldManager.Instance.headRotate, 0);

        //targetRotation = Quaternion.Euler(0, WorldManager.Instance.headRotate, 0);


        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

        //Debug.Log(colorSolid.a);


        if (WorldManager.Instance.rainyPercent >= .6f)
        {
            transform.position = Vector3.Slerp(transform.position, targetPosition, Time.deltaTime);
            //rend.material.color = Color.Lerp(colorSolid, colorFade, Time.deltaTime / 50);
            //colorSolid.a = Mathf.Lerp(1, 0, Time.deltaTime / 50);
            //Debug.Log(colorSolid.a);




        }
        else
        {
            transform.position = Vector3.Slerp(transform.position, startPosition, Time.deltaTime);
            //rend.material.color = Color.Lerp(colorFade, colorSolid, Time.deltaTime / 50);


        }


        //light.intensity = Mathf.Lerp(light.intensity, WorldManager.Instance.rainyPercent, Time.deltaTime);



        //yRotation = WorldManager.Instance.headRotate * 10;

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime);

        //targetRotation = Quaternion.Euler(new Vector3(10, yRotation, 0));

        //transform.rotation = targetRotation;

        //transform.RotateAround(Vector3.zero, Vector3.right, 10f * Time.deltaTime);
        //transform.LookAt(Vector3.zero);

    }
}
