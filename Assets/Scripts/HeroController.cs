using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

    const string SPEEDPARAMNAME = "speed";

    const string JUMPPARAMNAME = "jump";


    public float speedHero;
    public float jumpForceHero;
    public Transform groundTester;
    public LayerMask layerToTest;


    Animator anim;
    Rigidbody rigidbody3D;
    bool dirForward = true;
    bool onGround;
    private float groundTesterRadius = 0.5f;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rigidbody3D = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update() {


        //jump
         Collider[] groudCollision = Physics.OverlapSphere(groundTester.position, groundTesterRadius, layerToTest);
        if (Input.GetKeyDown(KeyCode.UpArrow) && groudCollision.Length>0)
        {
            rigidbody3D.AddForce(new Vector3(0f, jumpForceHero));
            anim.SetTrigger(JUMPPARAMNAME);
        }

        //move right or left
        float horizonMove = Input.GetAxis("Horizontal");
        rigidbody3D.velocity = new Vector3(horizonMove * speedHero, rigidbody3D.velocity.y);
        anim.SetFloat(SPEEDPARAMNAME, Mathf.Abs(horizonMove));
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
