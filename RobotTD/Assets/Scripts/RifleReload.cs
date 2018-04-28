using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleReload : MonoBehaviour {

public Animator riflereload;

 


 		void Start () 
		 {
			 riflereload = GetComponent<Animator>();

		 }
          void Update()
                     {
	                     if (Input.GetButtonDown("Fire1"))
	                     {
		                     riflereload.Play("shootReload");
	                     }
	                     
		                     
		                     
		                     
		                     
		                     
		                     
             // if(reload== true)
                     //{
                // animation.Play("Take 001");
                    // }
            //if(Input.GetButtonDown("Fire1"))
                   //  {
               //reload.SetBool("Reload", true);
			   //reload.SetBool("rifleIdol", false);
                  //  }
					// else if(reload == false)
						// {
						 //   reload.SetBool("Reload", false);
			   				//reload.SetBool("rifleIdol", true);
						// }
 
 
 
            }
}