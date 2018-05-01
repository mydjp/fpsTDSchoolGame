 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class wolfHealth : MonoBehaviour {
	public int currentHealth;
 	public int maxHealth = 20;
 	public Transform spawnPoint;
	public int points;

 	// Use this for initialization
 	void Start () {
 		currentHealth = maxHealth;
		
 	}

	 void Update()
	 {
		 if (currentHealth <= 0)
		 {
			 Destroy(gameObject);
		 }
	 }




	 public void TakeDamage(int damage){
		currentHealth -= damage;
		if(currentHealth <= 0){
			//Keep score at zero
			currentHealth=0;
			print("Wolf is Dead!");		
			// Add points to score for killing wolf	
			scoreManager.AddPoints(points);
			//Move wolf to spawn point for restart
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;	
			//Reset Wolf Health
			currentHealth = maxHealth;	
		}
	}
	 

 }
