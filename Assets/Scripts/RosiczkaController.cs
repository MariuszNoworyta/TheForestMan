using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RosiczkaController : MonoBehaviour {

    const string DIEPARAMNAME = "HeroTouch";
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            anim.SetTrigger(DIEPARAMNAME);
        }
    }

}
