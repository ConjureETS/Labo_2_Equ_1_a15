using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {


    public Transform thingsToMove;

    public float speed;          
    
    private int eulerAngle;     

	// Use this for initialization
	void Start () {

        eulerAngle = 0;

    }
	
	// Update is called once per frame
	void Update () {
        
        float mouvement = Input.GetAxis ("Horizontal");


        // aller vers la gauche
        if (mouvement > 0.0)
        {
            thingsToMove.Translate(new Vector2(mouvement * speed, 0));      // bouger le player
            eulerAngle = 0;

        } // if


        // aller vers la droite
        if (mouvement < 0.0)
        {

            thingsToMove.Translate(new Vector2(-(mouvement * speed), 0));   // bouger le player
            eulerAngle = 180;

        } // if

        transform.eulerAngles = new Vector3(0, eulerAngle, 0);              // gauche = sprite effet miroir, droite = sprite normal
    }
}
