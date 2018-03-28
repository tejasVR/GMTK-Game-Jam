using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    public Quaternion startRotation;
    public Quaternion targetRotation;

    public Color skyboxNormal = new Color (124.0f/225.0f, 124.0f / 225.0f, 124.0f / 225.0f, 225.0f / 225.0f);
    public Color skyboxNight = new Color(9.0f / 225.0f, 9.0f / 225.0f, 9.0f / 225.0f, 255.0f / 225.0f);

    //public Color skyboxNormal = new Color (0f, 0f, 0f, 0f);

    private Color skyboxCurrent;


    public Light light;

    public float yRotation;

    public Material skybox;

    public float tiltAngleY = 30f;

    

	// Use this for initialization
	void Start () {

        //startRotation = Quaternion.Euler(transform.rotation.eulerAngles);

        //targetRotation = Quaternion.Euler(-0.27f, 11.24f, -9.2f);


        //targetRotation = Quaternion

        light = GetComponent<Light>();

        
		
	}
	
	// Update is called once per frame
	void Update () {

        //targetRotation = Quaternion.Euler(0, tiltAngleY * WorldManager.Instance.headRotate, 0);

        //targetRotation = Quaternion.Euler(0, WorldManager.Instance.headRotate, 0);


        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

        //targetRotation = Quaternion.Euler(transform.rotation.eulerAngles);


        skyboxCurrent = skybox.GetColor("_Tint");
        
        //RenderSettings.skybox.GetColor();

        if (WorldManager.Instance.sunnyPercent >= .6f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
            //RenderSettings.skybox.SetColor("_Tint", Color.Lerp(new Color(RenderSettings.skybox.color.r, RenderSettings.skybox.color.g, RenderSettings.skybox.color.b, RenderSettings.skybox.color.a), skyboxNormal, Time.deltaTime));
            //RenderSettings.skybox.SetColor("_Tint", Color.Lerp(RenderSettings.skybox.color, skyboxNormal, Time.deltaTime));

            //RenderSettings.skybox.SetColor("_Tint", skyboxNormal);

            //RenderSettings.skybox.SetColor("_Tint", Color.Lerp(skyboxCurrent, new Color(.4f, .4f, .4f, .4f), Time.deltaTime));




        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, startRotation, Time.deltaTime);
            //RenderSettings.skybox.SetColor("_Tint", Color.Lerp(new Color(RenderSettings.skybox.color.r, RenderSettings.skybox.color.g, RenderSettings.skybox.color.b, RenderSettings.skybox.color.a), skyboxNight, Time.deltaTime));
            //RenderSettings.skybox.SetColor("_Tint", Color.Lerp(RenderSettings.skybox.color, skyboxNight, Time.deltaTime));

            //RenderSettings.skybox.SetColor("_Tint", Color.Lerp(skyboxCurrent, new Color(.04f, .04f, .04f, .04f), Time.deltaTime));

            //Debug.Log(RenderSettings.skybox.color);



        }

        RenderSettings.skybox.SetFloat("_Exposure", light.intensity);
        light.intensity = Mathf.Lerp(light.intensity, WorldManager.Instance.sunnyPercent, Time.deltaTime / 2);




        //yRotation = WorldManager.Instance.headRotate * 10;

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime);

        //targetRotation = Quaternion.Euler(new Vector3(10, yRotation, 0));

        //transform.rotation = targetRotation;

        //transform.RotateAround(Vector3.zero, Vector3.right, 10f * Time.deltaTime);
        //transform.LookAt(Vector3.zero);

    }
}
