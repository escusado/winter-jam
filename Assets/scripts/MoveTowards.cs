using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour {

	public Transform target;
	public float speed;

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
	}
}
