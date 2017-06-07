using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	public Transform target;
	Camera myCamera;
	// Use this for initialization
	void Start () {
		myCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {

		myCamera.orthographicSize = (Screen.height / 60f);

		if (target) {
			transform.position = Vector3.Lerp (transform.position, target.position, 0.2f) + new Vector3(0, 0, -10);
		}

	}
}
