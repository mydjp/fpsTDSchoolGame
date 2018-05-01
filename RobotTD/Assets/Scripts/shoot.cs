using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public Rigidbody projecticle;
	public Transform shootPoint;
	public int shootSpeed;
	
	public float coolDown = 1;
	public float coolDownTimer;

	// Use this for initialization
	
		
	
	
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
			
			Rigidbody clone;
			
			clone = (Rigidbody)Instantiate(projecticle, shootPoint.position, projecticle.rotation);

			clone.velocity = shootPoint.TransformDirection (Vector3.forward*shootSpeed*Time.deltaTime);
		}
			
		
			
		
		
	}
//checking cooldown
	void Attack()
	{
		
	}
		
		
		
		
	}

