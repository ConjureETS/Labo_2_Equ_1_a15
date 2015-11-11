using UnityEngine;
using System.Collections;

public class Patrolling : MonoBehaviour {

    
    private float direction = 0.5f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(direction, 0, 0);
	}

    void FixedUpdate() {
    }

    public void setDirection(float value) {
        direction = value;
    }

    public float getDirection() {
        return direction;
    }

}
