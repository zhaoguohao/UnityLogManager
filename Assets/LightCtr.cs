using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 模拟太阳
/// </summary>
public class LightCtr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(-0.1f, 0, 0), Space.World);
	}
}
