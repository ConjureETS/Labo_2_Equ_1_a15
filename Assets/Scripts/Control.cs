using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {


    public Transform thingsToMove;
    public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float mouvement = Input.GetAxis ("Horizontal");

        if ( mouvement!= 0)
        {
            thingsToMove.Translate(new Vector2(mouvement * speed, 0));
        }
	
	}
}
