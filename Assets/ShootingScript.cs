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
            int valOfLeftOrRight;
            if (gameObject.transform.rotation.y !=  0)
            {
                valOfLeftOrRight = -2;
            }
            else {
                valOfLeftOrRight = 2;
            }
            Vector3 missilePos = new Vector3(gameObject.transform.position.x + valOfLeftOrRight, gameObject.transform.position.y, gameObject.transform.position.z);
            GameObject clone = Instantiate(Missile, missilePos, transform.rotation) as GameObject;
        }
	}
}
