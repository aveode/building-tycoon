using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
	private Camera mainCamera;
	private BuildingTypeSO currentType;
	List<BuildingTypeSO> buildingTypes;

	private void Start()
	{
		mainCamera = Camera.main;
		buildingTypes = Resources.Load<BuildingTypeListSO>(nameof(BuildingTypeListSO)).list;
		currentType = buildingTypes[0];
	}

	private void Update()
	{	
		
		if(Input.GetKeyDown(KeyCode.T))
		{
			currentType = buildingTypes[0];
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			currentType = buildingTypes[1];
		}

		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(currentType.Prefab, getMouseWorldPosition(), Quaternion.identity);
		}
	}

	private Vector3 getMouseWorldPosition()
	{
		Vector3 mousePos;
		mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0f;
		return mousePos;
	}
}
