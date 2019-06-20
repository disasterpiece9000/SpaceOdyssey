using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject leftCannon, rightCannon, leftLaser, rightLaser;
    float laserSpeed = 10000;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newLeftLaser = GameObject.Instantiate(leftLaser, leftLaser.transform.position, Quaternion.identity);
            newLeftLaser.SetActive(true);
            newLeftLaser.GetComponent<Rigidbody>().AddForce(laserSpeed * transform.forward);

            GameObject newRightLaser = GameObject.Instantiate(rightLaser, rightLaser.transform.position, Quaternion.identity);
            newRightLaser.SetActive(true);
            newRightLaser.GetComponent<Rigidbody>().AddForce(laserSpeed * transform.forward);
        }
		
	}
}
