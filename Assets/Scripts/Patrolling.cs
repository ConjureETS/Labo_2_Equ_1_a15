using UnityEngine;
using System.Collections;

public class Patrolling : MonoBehaviour {

    
    public float speed;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
	}

    void FixedUpdate() {
    }

    public void setDirection(float value) {
        speed = value;
    }

    public float getDirection() {
        return speed;
    }

}
