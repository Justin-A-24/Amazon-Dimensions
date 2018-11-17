using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject[] prefabs;

    public EndFail end;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        if (end.strikes == 3)
        {
            return;
        }

        int rand = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[rand], spawnPoint.position, spawnPoint.rotation);

    }
}
