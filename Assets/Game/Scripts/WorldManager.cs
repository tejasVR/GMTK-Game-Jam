using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour {

    public static WorldManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public GameObject cameraGaze;

    public GameObject rainy;
    public GameObject sunny;

    //public float rainyDistance;
    //public float sunnyDistance;

    public float rainyDirection;
    public float sunnyDirection;

    public float rainyPercent;
    public float sunnyPercent;

    //public GameObject rainEffect;
    //public GameObject dustEffect;

    public float headRotate;


    private float lightRotationNight;
    private float lightRotationDay;

    //public Light sunLight;


    public Light rainPointLight;
    public Light sunPointLight;

    //public GameObject sun;
    private Light sunLight;
   // private Quaternion sunTargetRotation;
    //private Quaternion sunStartRotation;


    public ParticleSystem rainEffect;
    public ParticleSystem dustEffect;
    public ParticleSystem starEffect;

    public AudioSource moonSong;
    public AudioSource sunSong;
    public AudioSource moonSounds;
    public AudioSource morningSounds;



    // Use this for initialization
    void Start () {

        rainyDirection = 0f;
        sunnyDirection = 180f;

        lightRotationNight = -9f;
        lightRotationDay = 50f;


        //Quaternion sunStartRotation = Quaternion.Euler(100f, 4f, 5f);//Quaternion.Euler(sun.transform.rotation);
        //Debug.Log(sun.transform.localEulerAngles);

        //sunTargetRotation = Quaternion.Euler(9.893f, 3.19f, 117.298f);



        //sunLight = sun.GetComponent<Light>();
        moonSong.Play();
        sunSong.Play();


    }

    // Update is called once per frame
    void Update () {

        var rainMain = rainEffect.main;
        var starMain = rainEffect.main;
        var dustMain = dustEffect.main;


        //rainyDistance = Vector3.Distance(cameraGaze.transform.position, rainy.transform.position);

        //sunnyDistance = Vector3.Distance(cameraGaze.transform.position, sunny.transform.position);

        //sunnyDirection = Vector3.Distance(cameraGaze.transform.position, sunny.transform.position);


        //headRotate = cameraGaze.transform.rotation.eulerAngles.y;
        //if (cameraGaze.transform.eulerAngles.y)

        //Can be used as the percent of gaze, where 100% is facing the rain
        headRotate = Mathf.Abs(cameraGaze.transform.rotation.y);

        //sunnyPercent = (headRotate / sunnyDirection) * 100;//((headRotate / 180)-1) * 100;

        //sunLight.intensity = headRotate;

        //float lightAdjust = Mathf.Lerp()

        //Vector3 lightRotaion = new Vector3(50, -30, 0);

        //lightRotationDay * headRotate;
        //sunLight.transform.rotation.x = lightRotaion; 

        //Debug.Log(sunLight.intensity);

        



        rainyPercent = ((0 - headRotate) + 1);
        sunnyPercent = headRotate;

        /*if (rainyPercent >= .5f)
        {
            moonSong.volume = Mathf.Lerp(moonSong.volume, rainyPercent, Time.deltaTime);

        } else
        {
            moonSong.volume = Mathf.Lerp(moonSong.volume, 0, Time.deltaTime * 2);
        }

        if (sunnyPercent >= .5f)
        {
            moonSong.volume = Mathf.Lerp(moonSong.volume, rainyPercent, Time.deltaTime);

        }
        else
        {
            moonSong.volume = Mathf.Lerp(moonSong.volume, 0, Time.deltaTime * 2);
        }*/

        //moonSong.volume = rainyPercent;
        //sunSong.volume = sunnyPercent;



        //rainPointLight.intensity = rainyPercent;

        //sunPointLight.intensity = sunnyPercent;


        //rainMain.maxParticles = 10 * Mathf.RoundToInt(rainyPercent * 100);

        //rainMain.duration = 5f * rainyPercent;

        //starMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(starMain.maxParticles, rainyPercent * 1000, Time.deltaTime));



        if (rainyPercent >= .6f)
        {
            //rainMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(rainMain.maxParticles, rainyPercent * 1000, Time.deltaTime));
            dustMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(dustMain.maxParticles, rainyPercent * 1000, Time.deltaTime));

            starMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(starMain.maxParticles, rainyPercent * 1000, Time.deltaTime));

            moonSong.volume = Mathf.Lerp(moonSong.volume, rainyPercent, Time.deltaTime);
            moonSounds.volume = Mathf.Lerp(moonSounds.volume, rainyPercent - .2f, Time.deltaTime);



            //sunSong.volume = Mathf.Lerp(moonSong.v;



            //Debug.Log("YesRain");

        }
        else if (rainyPercent < .6f)
        {

            //rainMain.maxParticles = 0;
           // rainMain.duration = 1f;
           //rainMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(rainMain.maxParticles, 0, Time.deltaTime * 15));
           //dustMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(dustMain.maxParticles, sunnyPercent * 1000, Time.deltaTime));
            dustMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(dustMain.maxParticles, 0, Time.deltaTime * 15));
            starMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(starMain.maxParticles, 0, Time.deltaTime * 15));

            moonSong.volume = Mathf.Lerp(moonSong.volume, 0, Time.deltaTime * 2);
            moonSounds.volume = Mathf.Lerp(moonSounds.volume, 0, Time.deltaTime * 2);





            //rainMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(rainMain.maxParticles, rainMain.maxParticles - 10, Time.deltaTime));
            //rainMain.maxParticles -= 10;
            //Debug.Log("NoRain");
            //Debug.Log(Mathf.Lerp(rainMain.maxParticles, 0, Time.deltaTime * 100));
        }

        if (sunnyPercent >= .6f)
        {
            sunSong.volume = Mathf.Lerp(sunSong.volume, sunnyPercent, Time.deltaTime);
            morningSounds.volume = Mathf.Lerp(morningSounds.volume, sunnyPercent - .2f, Time.deltaTime);


            //dustMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(dustMain.maxParticles, sunnyPercent * 1000, Time.deltaTime));
            //sun.transform.eulerAngles = Vector3.Lerp(sun.transform.eulerAngles, sunTargetRotation * sunnyPercent, Time.deltaTime);
            //sun.transform.rotation = Quaternion.RotateTowards(transform.rotation, sunTargetRotation, Time.deltaTime * 30);



            //Debug.Log("YesRain");

        }
        else if (sunnyPercent < .6f)
        {
            //rainMain.maxParticles = 0;
            //dustMain.maxParticles = Mathf.RoundToInt(Mathf.Lerp(dustMain.maxParticles, 0, Time.deltaTime * 15));
            //sun.transform.rotation = Quaternion.RotateTowards(transform.rotation, sunStartRotation, Time.deltaTime * 30);
            //Debug.Log("NoRain");
            //Debug.Log(Mathf.Lerp(rainMain.maxParticles, 0, Time.deltaTime * 100));

            sunSong.volume = Mathf.Lerp(sunSong.volume, 0, Time.deltaTime * 2);
            morningSounds.volume = Mathf.Lerp(morningSounds.volume, 0, Time.deltaTime * 2);


        }




        //dustMain.maxParticles = 1000 * Mathf.RoundToInt(rainyPercent);

        //rainEffect.particleSystem.maxParticles = 1000 * Mathf.RoundToInt(rainyPercent);

        //rainy.transform.position = Vector3.Lerp(rainy.transform.position, new Vector3(rainy.transform.position.x, 2 * rainyPercent, rainy.transform.position.z), Time.deltaTime);
        //sunny.transform.position = Vector3.Lerp(sunny.transform.position, new Vector3(sunny.transform.position.x, 2 * sunnyPercent, sunny.transform.position.z), Time.deltaTime);


        //if (sunnyDistance <= 3f)


    }
}
