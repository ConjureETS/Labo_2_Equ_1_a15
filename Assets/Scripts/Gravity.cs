using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    public Character player;

    void Start()
    {
        player = new Character(1, 10, 10, false);
    }
	
	// Update is called once per frame
	void Update () {

        if (!player.isTouchingTheFloor())
        {
            this.gameObject.transform.Translate(0,-0.1f,0);
        }

        if (Input.GetKey("p"))
        {
            player.setTouchingTheFloor(false);
        }
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            player.setTouchingTheFloor(true);
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            
            player.setTouchingTheFloor(false);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            player.setTouchingTheFloor(true);
        }
    }
}
