using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
	[Header("Attributes")]
	public Transform target;
	public float range = 15f;
	public float fireRate = 1F;
	private float fireCountdown = 0f;

	[Header("Need to put stuff here!!")]
	public string enemyTag = "Enemy";

	public Transform partToRotate;
	public float turnSpeed = 10f;

	public GameObject STbulletPrefab;
	public Transform firePoint;

	public float shortestDistance;
	
	

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("UpdateTarget", 0f, 0.1f);
	}

	void UpdateTarget ()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;

		foreach (GameObject enemy in enemies)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range)
		{
			target = nearestEnemy.transform;
		}
		else
		{
			target = null;
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		//UpdateTarget();

		if (target == null)
			return;
// target lock on
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 roatation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		partToRotate.rotation = Quaternion.Euler(0f, roatation.y, 0f);

		if (fireCountdown <= 0f)
		{
			Shoot();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;

	}

	void Shoot()
	{
		GameObject STbulletGo = (GameObject) Instantiate(STbulletPrefab, firePoint.position, firePoint.rotation);
		STBullet bullet = STbulletGo.GetComponent<STBullet>();

		if (bullet != null)
			bullet.Seek(target);
	}

	private void OnDrawGizmosSelected()

	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
