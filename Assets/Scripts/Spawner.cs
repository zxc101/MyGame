using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public List<GameObject> objects;
    public float timeSpawn = 1f;

    private System.Random r;


    void Start () {
        InvokeRepeating("Spawn", 0, timeSpawn);
        r = new System.Random();
    }
	
	void FixedUpdate () {
		
	}

    void Spawn()
    {
        Instantiate(objects[r.Next(0, 2)], transform.position, transform.rotation);
    }
}
