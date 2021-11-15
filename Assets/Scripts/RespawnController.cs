using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hero")
        {
            HeroController heroC = other.gameObject.GetComponent<HeroController>();
            heroC.LastRespawn = this.transform.position;
        }
    }
}
