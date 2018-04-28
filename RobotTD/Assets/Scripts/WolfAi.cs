using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAi : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}	
	}

	void OnCollisionEnter(Collision other)
	{
		print("Wolf is attacking RUN !!");
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();

		other.gameObject.GetComponent<PlayerHealth>();

		if(health != null){
		 	health.TakeDamage(damage);
		 }
	}

}
