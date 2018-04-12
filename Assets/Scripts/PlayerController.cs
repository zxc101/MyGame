using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5f;
    public float jumpForce = 10f;
    
    private Rigidbody2D rigidbody;

    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0, 1000) * jumpForce);
        }
    }
}
