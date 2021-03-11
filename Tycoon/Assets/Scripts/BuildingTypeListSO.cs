using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableOBJ/BuildingTypeList")]
public class BuildingTypeListSO : ScriptableObject
{
	public List<BuildingTypeSO> list;
}
