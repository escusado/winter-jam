using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class directionMover : MonoBehaviour {
	
	public bool horizontal;
	public float speed;
	
	void Start () {
		
		if(horizontal){
			transform.LookAt(transform.position + transform.right);	
		}
		
		rigidbody.velocity = transform.forward * speed;
	}
}
