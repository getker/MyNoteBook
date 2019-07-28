using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float speed = 500f;
    public Text text;
    public GameObject winText;

    int score = 0;
    Rigidbody rgd;

	// Use this for initialization
	void Start () {
        winText.SetActive(false);
        rgd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rgd.AddForce(new Vector3(h, 0, v) * speed * Time.deltaTime);
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "PickUp")
        {
            score++;
            text.text = score.ToString();
            Destroy(collider.gameObject);
            if(score >= 10)
            {
                winText.SetActive(true);
            }
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.collider.tag == "PickUp")
    //    {
    //        Destroy(collision.collider.gameObject);
    //    }
    //}
}
