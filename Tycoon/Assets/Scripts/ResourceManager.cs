using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
	private Dictionary<ResourceTypeSO, int> resourceInfoDictionary;
	public static ResourceManager Instance { get; private set; }

	private void Awake()
	{
		Instance = this;
		resourceInfoDictionary = new Dictionary<ResourceTypeSO, int>();

		ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(nameof(ResourceTypeListSO));

		foreach (ResourceTypeSO resourceType in resourceTypeList.list)
		{
			resourceInfoDictionary[resourceType] = 0;
		}
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.T))
		{
			ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(nameof(ResourceTypeListSO));
			AddResource(resourceTypeList.list[0], 10);
		}
	}

	public void AddResource(ResourceTypeSO resourceType, int amount)
	{
		resourceInfoDictionary[resourceType] += amount;
		LogResources();
	}

	private void LogResources()
	{
		foreach (ResourceTypeSO resourceType in resourceInfoDictionary.Keys)
		{
			Debug.Log(resourceType.nameString + ": " + resourceInfoDictionary[resourceType]);
		}
	}
}
