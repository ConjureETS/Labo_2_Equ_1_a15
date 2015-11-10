using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

    private Animator anim;
    private bool isShooting;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        isShooting = false;

    }
	
	// Update is called once per frame
	void Update () {

        float mouvementX = Input.GetAxis("Horizontal");


        if (Input.GetKeyDown(KeyCode.X))
        {
            isShooting = true;
        } // if

        
        if (Input.GetKeyUp(KeyCode.X))
        {
            isShooting = false;
        } // if

        
        anim.SetFloat("SpeedX", Mathf.Abs(mouvementX));
        anim.SetBool("isShooting", isShooting);

    }
}
