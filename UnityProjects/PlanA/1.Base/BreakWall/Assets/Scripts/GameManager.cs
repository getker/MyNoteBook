using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Transform mainCam;
    public GameObject zidan;
    public float shootSpeed = 50f;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = GameObject.Instantiate(zidan, mainCam.position, mainCam.rotation);
            Rigidbody rgd = b.GetComponent<Rigidbody>();
            rgd.velocity = mainCam.forward * shootSpeed;
        }
    }
    
}
