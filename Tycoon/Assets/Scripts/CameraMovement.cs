using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	private Vector3 movement;
	[SerializeField]private float minCamSpeed = 0.07f, baseCamSpeed = 0.1f, maxCamSpeed = 0.18f;




	private void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
		this.transform.position += movement * getSpeed();

	}

	private float getSpeed()
	{
		float camSpeed;

		if (Input.GetKey(KeyCode.LeftShift))
		{
			camSpeed = maxCamSpeed;
		}
		else if (Input.GetKey(KeyCode.LeftControl))
		{
			camSpeed = minCamSpeed;
		}
		else
		{
			camSpeed = baseCamSpeed;
		}

		return camSpeed;
	}
}
