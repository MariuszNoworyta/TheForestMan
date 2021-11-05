using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

    const string PARAMSPEED = "speed";
    const float SPEED = 1.5f; 


    Animator anim;
    Rigidbody rigidbody3D;
    bool dirForward = true;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rigidbody3D = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update() {
        float horizonMove = Input.GetAxis("Horizontal");
        rigidbody3D.velocity = new Vector3(horizonMove * SPEED, rigidbody3D.velocity.y);

        anim.SetFloat(PARAMSPEED, Mathf.Abs(horizonMove));


        if ((horizonMove < 0 && dirForward)|| (horizonMove > 0 && !dirForward))
        {
            FilpX();
        }




	}

    private void FilpX()
    {
        Vector3 heroScale = this.transform.localScale;
        heroScale.x *= -1.0f;
        this.transform.localScale = heroScale;
        dirForward = heroScale.x > 0;
    }
}
