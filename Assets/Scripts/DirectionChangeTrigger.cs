using UnityEngine;
using System.Collections;

public class DirectionChangeTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) { 
        if( other.gameObject.tag == "Ennemy" ){
            other.gameObject.GetComponent<Patrolling>().setDirection(- other.gameObject.GetComponent<Patrolling>().getDirection());
            print("TriggerEnter");
        }
    }
}
