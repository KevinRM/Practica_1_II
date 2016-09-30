using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	private Rigidbody body;
	public float speed = 20;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float vertical = Input.GetAxis("Vertical");
		float horizontal = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(horizontal, 0f, vertical);
		body.AddForce(move * speed);
	}
}
