using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public int timeJump;

    public Transform player;

    private bool isJumping; //

	// Use this for initialization
	void Start () {
        isJumping = false;
        timeJump = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1") && isJumping == false)
        {
            timeJump = 50;
            isJumping = true;
        }

        if (timeJump > 0) {
            player.Translate(0, 0.5f, 0);
            timeJump--;      
        }
        else
        {
            isJumping = false;
        }
	
	}
}
