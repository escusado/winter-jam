using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	public string receiveDamageFrom;

	void OnTriggerEnter(Collider other){
		if(other.tag == receiveDamageFrom){
			Health myHealth = GetComponent<Health>();
			BulletBehavior currentBullet = other.GetComponent<BulletBehavior>();
			myHealth.health -= currentBullet.damage;

			if(myHealth.health <= 0){
				Destroy(gameObject);
			}
		}
	}
}
