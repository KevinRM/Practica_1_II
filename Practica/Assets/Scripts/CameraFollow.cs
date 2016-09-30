using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Pelota");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.LookAt (player.transform);
		Vector3 pos = transform.position;
		pos.y = transform.position.y;
		pos.z = player.transform.position.z - 30;
		transform.position = pos;
	}
}
