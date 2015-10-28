using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    public Character player;
	
	// Update is called once per frame
	void Update () {
        int test = player.getMass();
	}
}
