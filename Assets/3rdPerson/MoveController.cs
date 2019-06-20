using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

    public GameObject fullShip;

    float moveSpeed = 250.0f;
    float rotateSpeed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.W))
        {
            Quaternion targetRot = Quaternion.Euler(-45, 0, 0);
            fullShip.transform.rotation = Quaternion.Lerp(fullShip.transform.rotation, targetRot, rotateSpeed * Time.deltaTime);

            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            Quaternion targetRot = Quaternion.Euler(45, 0, 0);
            fullShip.transform.rotation = Quaternion.Lerp(fullShip.transform.rotation, targetRot, rotateSpeed * Time.deltaTime);

            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion targetRot = Quaternion.Euler(0, 0, 45);
            fullShip.transform.rotation = Quaternion.Lerp(fullShip.transform.rotation, targetRot, rotateSpeed * Time.deltaTime);

            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion targetRot = Quaternion.Euler(0, 0, -45);
            fullShip.transform.rotation = Quaternion.Lerp(fullShip.transform.rotation, targetRot, rotateSpeed * Time.deltaTime);

            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        else
        {
            Quaternion targetRot = Quaternion.Euler(0, 0, 0);
            fullShip.transform.rotation = Quaternion.Lerp(fullShip.transform.rotation, targetRot, rotateSpeed * Time.deltaTime);
        }
	}
}
