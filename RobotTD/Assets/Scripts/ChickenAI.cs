using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	// Public 
	public Transform wolf;
	public float speed;

	public int damage;
	// Wander 
	public float wanderRadius;
    public float wanderTimer;
	//Detection 
	public float alertDist;
	public float attackDist;
	// Private 
	private Animator state;
	private Vector3 direction;
	private Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	private float timer;
	private float distance;

	public Transform chickenPen;

	void OnEnable () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
        timer = wanderTimer;
    }
	// Use this for initialization
	void Start () {
		state = GetComponent<Animator>();
		distance = Vector3.Distance(wolf.position, transform.position);
	}
	
	// Update is called once per frame
	void Update ()
     {
		distance = Vector3.Distance(wolf.position, transform.position);
		
		// Alert
		if(distance < alertDist && distance > attackDist)
        {
			
			state.SetBool("Run Away",true);
			state.SetBool("Wander",false);
			
			speed = 13;
			//transform.LookAt(wolf);
			transform.LookAt(2 * transform.position - wolf.position);
            //2 * transform.position- lookingAt.position
			transform.Translate(Vector3.forward*speed*Time.deltaTime);

		}
	          //Wandering
		else if(distance > alertDist)
        {
			 timer += Time.deltaTime;

			 	state.SetBool("Run Away",false);
				
				state.SetBool("Wander",true);

			if (timer >= wanderTimer)
            {
			Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
			agent.SetDestination(newPos);
			timer = 0;
			}


		}  
    }
		
		

		
	

	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
     {
        Vector3 randDirection = Random.insideUnitSphere * dist;
 
        randDirection += origin;
 
        UnityEngine.AI.NavMeshHit navHit;
 
        UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
 
        return navHit.position;
    }

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player")
		{
		
			//Send chicken to chicken pen.
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
			print ("go to the pen");

		}
	}
}