using UnityEngine;
using System.Collections;

public class RacketController1 : MonoBehaviour {

	
	void Update () {
		if (Input.GetKey("right")){
			transform.position += new Vector3 (0.5f, 0f, 0f);
	}
		if (Input.GetKey("left")){
			transform.position += new Vector3 (-0.5f, 0f, 0f);
		}
	}
}
