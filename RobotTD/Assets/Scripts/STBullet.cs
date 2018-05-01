using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class STBullet : MonoBehaviour
{

	private Transform target;
	public float speed = 70f;
	public int damage = 10;

	public int time = 5;

	public void Seek(Transform _target)
	{
		target = _target;
	}

	void Start()
	{
	}
			void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			other.gameObject.GetComponent<wolfHealth>().TakeDamage(damage);
			Destroy(gameObject);
			
		}
	}
	
	
	// Update is called once per frame
	void Update () {

		if (target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}

	void HitTarget()
	{
		Destroy(gameObject);
	}
}
