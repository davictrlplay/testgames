using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {

		speed = 1;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {

			this.transform.Translate (Vector3.forward);
		}
		
	}
}
