using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapActive : MonoBehaviour {

	public GameObject Map;

	// Use this for initialization
	void Start () {
		Map.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoActive(bool active){
		if (Map)
			Map.SetActive (active);
	}
}
