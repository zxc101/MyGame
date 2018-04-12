using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazookaController : MonoBehaviour {

    public GameObject rocket;

	void Start () {
	}
	
	void FixedUpdate() {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(rocket, transform.position, transform.rotation);
        }
	}
}
