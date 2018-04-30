using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Bullet : MonoBehaviour
{

	public int damage = 10;

	public int time = 5;

	// Use this for initialization
	void Start()
	{
		//StartCoroutine(DestroyBullet());

	}

	

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			other.gameObject.GetComponent<wolfHealth>().TakeDamage(damage);
			Destroy(gameObject);
			Debug.Log("Pew Pew");
		}
	}


// Update is called once per frame
	
	//IEnumerator DestroyBullet(){
		//yield return new WaitForSeconds(time);
	//	Destroy(gameObject);
	//}

}