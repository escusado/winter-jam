using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	public string targetTag;
	public int damage;

	void OnTriggerEnter(Collider other) 
	{
		
		if (other.tag == this.targetTag)
		{
			Destroy(gameObject);
			return;
		}


	}
}
