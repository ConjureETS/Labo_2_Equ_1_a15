using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    // le player
    public Rigidbody2D player;

    private float positionPlayerX;      // position du player en X
    private float positionPlayerY;      // // position du player en Y


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        // definir la position du player
        positionPlayerX = player.GetComponent<Rigidbody2D>().position.x;
        positionPlayerY = player.GetComponent<Rigidbody2D>().position.y;

        // ajuster la camera selon la position du player
        transform.position = new Vector3(positionPlayerX, positionPlayerY + 3.5F, -10);

    }
}
