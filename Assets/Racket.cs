using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

	private float accel = 1000.0f;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*this.GetComponent<Rigidbody> ().AddForce (
			transform.right * Input.GetAxisRaw ("Horizontal") * accel,
			ForceMode.Impulse);*/
		App_Touch.TouchInfo touch = App_Touch.GetTouch ();
		if (touch == App_Touch.TouchInfo.Began) {


		}
		if (touch == App_Touch.TouchInfo.Moved) {
			pos = App_Touch.GetTouchPosition();
			pos.y = 0.0f;
			pos.z = -6.0f;
			transform.position = pos;
		}
		if (touch == App_Touch.TouchInfo.Ended) {
		}
	}

}
