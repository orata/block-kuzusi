using UnityEngine;
using System.Collections;

public class RacketController1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey ("right")) {
			transform.position += new Vector3 (Input.GetAxis("Horizontal"), 0f, 0f); 

		}

	}
}
