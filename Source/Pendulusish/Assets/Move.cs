using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			gameObject.GetComponent<Rigidbody>().AddForce(5, -2, 0, ForceMode.Impulse);
		}
		else if (Input.GetKey(KeyCode.B)) {
			gameObject.GetComponent<Rigidbody>().AddForce(3, -1, 0, ForceMode.Impulse);
		}
		else if (Input.GetKey(KeyCode.C)) {
			gameObject.GetComponent<Rigidbody>().AddForce(1, 0, 0, ForceMode.Impulse);
		}
		else if (Input.GetKey(KeyCode.D)) {
			gameObject.GetComponent<Rigidbody>().AddForce(-1, 0, 0, ForceMode.Impulse);
		}
	}
}
