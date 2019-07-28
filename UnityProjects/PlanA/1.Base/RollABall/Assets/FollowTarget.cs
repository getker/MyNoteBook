using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

    public Transform playerTran;

    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - playerTran.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = playerTran.position + offset;
	}
}
