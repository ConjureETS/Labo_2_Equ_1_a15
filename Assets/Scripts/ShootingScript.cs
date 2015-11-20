using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

    public float attackSpeed;
    private float nextShootTime = 0.0f;
    public GameObject Missile;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButton("Fire1") && Time.time > nextShootTime){
            print("pewpew");
            nextShootTime = Time.time + attackSpeed;
            //avancer le missile au depart quand il va apparaitre (quand je vais avoir anim de combat)
            GameObject clone = Instantiate( Missile,transform.position,transform.rotation) as GameObject;
        }
	}
}
