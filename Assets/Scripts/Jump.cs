using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public Rigidbody2D player;      // le player

    public float playerSpeedY;      // la vitesse de saut

    private bool isOnGround;        // somme nous sur le sol?


	// Use this for initialization
	void Start () {
        isOnGround = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space) && isOnGround == true)
        {
            player.velocity = new Vector2(player.velocity.x, playerSpeedY);
        }

	}


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            isOnGround = true;
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            isOnGround = true;
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {

            isOnGround = false;
        }

    }



}
