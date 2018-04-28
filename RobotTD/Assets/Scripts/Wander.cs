using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {
	public float moveSpeed;
	public Transform target;



//	public int damage;

//	public GameObject pcHealth;

	public void Wandering(){
		print("Chicken is Wandering");

		//Makes the animal wander 
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		int randomNum = Random.Range(60,300);
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;

		// Draws the physical ray
		Debug.DrawRay(transform.position,fwd*3,Color.red);
		// Detects collision ussing raycast
		if(Physics.Raycast(transform.position,fwd,out hit,3)){

			if (hit.collider.tag == "Wall"){
				transform.Rotate(0,randomNum,0);

			}
		}
	}


 void OnTriggerStay(Collider other)
{
		if(other.gameObject.name == "Player"){
			print("Player stinks");

		}
		else {
			Wandering();
		}
	
}
}
