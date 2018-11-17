using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomObjectSpawner : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject[] prefabs;
    public float spawnTime = 3f;
    public EndFail end;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void Spawn()
    {
        if (end.strikes >= 5)
        {
            GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Circles");
            foreach (GameObject objects in prefabs)
                Destroy(objects);

            GameObject[] triangles = GameObject.FindGameObjectsWithTag("Triangles");
            foreach (GameObject objects in triangles)
                Destroy(objects);

            GameObject[] squares = GameObject.FindGameObjectsWithTag("Squares");
            foreach (GameObject objects in squares)
                Destroy(objects);


            return;
        }

        int rand = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[rand], spawnPoint.position, Quaternion.identity);

    }
}
