using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

    const string PARAMSPEED = "speed";

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizonMove = Input.GetAxis("Horizontal");
        anim.SetFloat(PARAMSPEED, Mathf.Abs(horizonMove));
        Vector3 heroScale = this.transform.localScale;
        if (horizonMove < 0 && heroScale.x > 0)
        {
            heroScale.x *= -1.0f;
            this.transform.localScale = heroScale;
        }
        else if (horizonMove > 0 && heroScale.x < 0)
        {
            heroScale.x *= -1.0f;
            this.transform.localScale = heroScale;
        }
	}
}
