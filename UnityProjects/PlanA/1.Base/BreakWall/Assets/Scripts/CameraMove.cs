using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    
    public float speed = 5f;
    
    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(h, v, 0) * Time.deltaTime * speed);
            // this.transform.position += new Vector3(h, v, 0) * speed * Time.deltaTime;
        }
    }
}
