using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	float speed = 10.0f;

	void Start () {
	}
	
	// Update is called once per frame
	void Update() {

		// Movement using arrow keys
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;

		// Movement using touch screen
		var touch = Input.GetTouch (0);
		Vector3 moveTouch = new Vector3(touch.position.x, touch.position.y, 0);
		transform.position += moveTouch * speed * Time.deltaTime;
	}
}