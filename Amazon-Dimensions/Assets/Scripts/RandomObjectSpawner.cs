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
        if (end.strikes >= 3)
        {
            GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Objects");
            foreach (GameObject objects in prefabs)
                Destroy(objects);
            return;
        }

        int rand = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[rand], spawnPoint.position, Quaternion.identity);

    }
}
