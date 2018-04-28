using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{


	public GameObject model1A;

	public GameObject model1B;

	public GameObject model1C;

	private int modelNumber;
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		modelNumber = 1;
		model1B.SetActive(false);
		model1C.SetActive(false);
		

	}

	void ModelSwtich()
	{
		if (modelNumber == 1)
		{
			model1A.SetActive(false);
			model1B.SetActive(true);
			modelNumber = 2;

		}else if (modelNumber == 2)
		{
			model1B.SetActive(false);
			model1C.SetActive(true);
			modelNumber = 3;

		}
		else if (modelNumber == 3)
			{
				model1C.SetActive(false);
				model1A.SetActive(true);
				modelNumber = 1;
			}
				
			}

	private void Update()
	{
		if (Input.GetMouseButtonDown(2))
		{
			ModelSwtich();
		}
	}
}
	
	
