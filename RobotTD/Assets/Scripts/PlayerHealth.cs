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
		currentHealth = maxHealth;
		SetHealthBar();
		

	}

	public void TakeDamage(float amount)
	{
		currentHealth -= amount;
		SetHealthBar();
		if (currentHealth <= 0)
		{
			currentHealth = 0;
			print("Youre Dead! GameOver");
		}
	}

	public void SetHealthBar()
	{
		float my_health = currentHealth / maxHealth;
		healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f),healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	
	}
	
	
}


