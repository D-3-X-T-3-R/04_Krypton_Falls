using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var horizontal_movement = CrossPlatformInputManager.GetAxis("Horizontal");
        var vertical_movement = CrossPlatformInputManager.GetAxis("Vertical");
        print(vertical_movement);
	}
}
