using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    Vector3 direction;
    float distance;
    float time;

	// Use this for initialization
	void Start () {
        time = Random.Range(0.25f, 1.0f);
        //direction = new Vector3(transform.position.x, transform.position.y, -200);
        direction = -Vector3.forward*200;
        distance = direction.magnitude;

        float randomScale = Random.Range(10.0f, 15.0f);
        transform.localScale = new Vector3(randomScale, randomScale, randomScale);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z < -100)
        {
            Destroy(transform.gameObject);
            //Debug.Log("Asteroid despawned");
        }
        else transform.Translate(direction.normalized * (Time.deltaTime * (distance / time)));
	}
}
