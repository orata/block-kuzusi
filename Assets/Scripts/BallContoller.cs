using UnityEngine;
using System.Collections;

public class BallContoller : MonoBehaviour {
	public int power = 500;
		private Rigidbody _rigidbody;

	void Awake(){
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		this._rigidbody.AddForce (Vector3.right * power);
		this._rigidbody.AddForce (Vector3.forward * power);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
