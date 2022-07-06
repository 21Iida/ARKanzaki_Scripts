using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マップの表示を切り替えます
/// <summary>
public class MapActive : MonoBehaviour {

	public GameObject Map;

	void Start () {
		Map.SetActive (false);
	}
	
	public void GoActive(bool active){
		if (Map)
			Map.SetActive (active);
	}
}
