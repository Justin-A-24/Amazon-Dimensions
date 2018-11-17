using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packaging : MonoBehaviour {

    public GameObject player;

    public int packagedValue;

	// Use this for initialization
	void Start () {

        player.GetComponent<GameObject>();
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag ("Objects"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(other.gameObject);
            }
            //Destroy(other.gameObject);
        }

    }

    // Update is called once per frame
    void Update () {


		
	}
}
