using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour {

    public Vector3 startPosition;
    public Vector3 targetPosition;





    // Use this for initialization
    void Start () {

        startPosition = transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {

        if (WorldManager.Instance.sunnyPercent >= .6f)
        {
            //transform.position = startPosition;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 2.5f);

        }
        else if (WorldManager.Instance.sunnyPercent < .6f)
        {
            transform.position = startPosition;
        }


    }
}
