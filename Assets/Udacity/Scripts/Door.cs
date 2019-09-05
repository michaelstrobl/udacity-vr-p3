using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

	bool door_locked = false;

    void Update() {

    	// If the door is unlocked and it is not fully raised
    	if (door_locked && transform.position.y < 19.0f) {
    		// Animate the door raising up
    		transform.Translate(0, +5f * Time.deltaTime, 0, Space.World);
    	}
    }

    public void Unlock()
    {
		
		 // You'll need to set "locked" to true here
		door_locked = true;		
		// Play Sound
		GetComponent<AudioSource> ().Play ();
		Debug.Log ("Door Unlocked!");
    }
}
