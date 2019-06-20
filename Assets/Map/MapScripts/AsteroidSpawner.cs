using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    // Normal asteroid prefabs
    public GameObject spawnPoint,
                      normalAstr1, normalAstr2, normalAstr3, normalAstr4, normalAstr5;

    // Asteroid spawn settings
    float spawnTimer = 0.5f;
    System.DateTime lastSpawnTime = System.DateTime.Now;
    int numSpawn = 15;
    int numSpawnCap = 35;
    int spawnCount = 0;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if ((System.DateTime.Now - lastSpawnTime).TotalSeconds > spawnTimer)
        {
            int randomSpawnNum = Random.Range((numSpawn * 3) / 4, numSpawn);
            for (int i = 0; i < randomSpawnNum; i++)
            {
                float randX = Random.Range(spawnPoint.transform.position.x - 2000, spawnPoint.transform.position.x + 2000);
                float randY = Random.Range(spawnPoint.transform.position.y - 1000, spawnPoint.transform.position.y + 1000);
                Vector3 pos = new Vector3(randX, randY, transform.position.z);

                GameObject newAstrType = getNormalAstr();
                GameObject newAstr = Instantiate(newAstrType, pos, Quaternion.identity);
                newAstr.SetActive(true);
                //Debug.Log("Spawned Asteroid: " + newAstrType.name);
            }

            lastSpawnTime = System.DateTime.Now;
            spawnCount++;
            //Debug.Log("Spawned " + randomSpawnNum + " asteroids");

            if (spawnCount % 10 == 0 && spawnCount < numSpawnCap)
            {
                numSpawn += (int)(numSpawn * 0.1);
                //Debug.Log("Number of asteroids spawned increased to " + numSpawn);
            }
        }
	}

    // Return a random normal asteroid
    GameObject getNormalAstr()
    {
        int astrNum = (int) Random.Range(1, 5);
        switch (astrNum)
        {
            case 1: return normalAstr1;
            case 2: return normalAstr2;
            case 3: return normalAstr3;
            case 4: return normalAstr4;
            case 5: return normalAstr5;
            default: return normalAstr1;
        }
    }
}
