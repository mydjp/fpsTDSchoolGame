using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{


	public Image healthBar;
	public float maxHealth = 100;
	public float currentHealth = 0f;

	public Text hp;
	public Text maxHP;

	 void Start()
	{
	
		

	}

	public void TakeDamage(float amount)
	{
		currentHealth -= amount;
		
		if (currentHealth <= 0)
		{
			currentHealth = 0;
			print("Youre Dead! GameOver");
		}
	}

	
	
	
}


