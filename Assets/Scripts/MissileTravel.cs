using UnityEngine;
using System.Collections;

public class MissileTravel : MonoBehaviour {
    public float missileSpeed;
    private Transform missilePos;
    private bool inContact = false;

    // ajouter du damage

	// Use this for initialization
	void Start () {
        this.missilePos = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (!inContact)
        {
            this.missilePos.Translate(new Vector3(missileSpeed, 0, 0) * Time.deltaTime);
        }
	}

    void OnCollisionEnter2D(Collision2D other) {
        print("missile touche");
        if (other.gameObject.tag == "Ennemy") {
            // do shits to player
            print("touchee");
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Floor") {
            Destroy(this.gameObject);
        }
    }

}
