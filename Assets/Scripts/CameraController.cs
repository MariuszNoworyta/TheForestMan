using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject hero;
    public float smoothCameraFollowMove;
    public float offsetYCamera;


    private Vector3 currentVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        Vector3 cameraFollowHeroNew = new Vector3(hero.transform.position.x, (hero.transform.position.y+ offsetYCamera )*1.2f, this.transform.position.z);

        this.transform.position = Vector3.SmoothDamp(this.transform.position, cameraFollowHeroNew, ref currentVelocity, smoothCameraFollowMove);


    }
}
