using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class FireRate : MonoBehaviour
{

	public float coolDown = 1;
	public float coolDownTimer;
	
	// Update is called once per frame
	void Update () 
	{

		if (coolDownTimer > 0)
		{
			coolDownTimer -= Time.deltaTime;
		}

		if (coolDownTimer < 0)
		{
			coolDownTimer = 0;
		}

		if (Input.GetButton("Fire1") && coolDownTimer == 0)
		{
			Attack();
			coolDownTimer = coolDown;
		}
		
	}

	void Attack()
	{
		Debug.Log("Pew Pew");
	}
}
