using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestory : MonoBehaviour {
    Transform floor;
    float floorY = 0;
    void Awake()
    {
        floor = GameObject.Find("Floor").transform;
        floorY = floor.position.y;
    }

	void Update () {
		if(transform.position.y < floorY)
        {
            GameObject.Destroy(this.gameObject);            
        }
	}
}
