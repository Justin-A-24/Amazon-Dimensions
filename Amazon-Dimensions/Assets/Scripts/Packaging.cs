using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packaging : MonoBehaviour {

    public GameObject player;

    public AudioSource packagedSFX;

    public int packagedValue;

    public EndFail end;

	// Use this for initialization
	void Start () {

        player.GetComponent<GameObject>();
        end.GetComponent<EndFail>();
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag ("Circles"))
        {
            if (Input.GetKey(KeyCode.Q))
            {
                packagedSFX.gameObject.GetComponent<AudioSource>().Play();
                Destroy(other.gameObject);
            }
            //else
            //{
            //    end.strikes = end.strikes + 1;
            //    Destroy(other.gameObject);
            //}
        }

        else if (other.gameObject.CompareTag("Squares"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                packagedSFX.gameObject.GetComponent<AudioSource>().Play();
                Destroy(other.gameObject);
            }
            //Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("Triangles"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                packagedSFX.gameObject.GetComponent<AudioSource>().Play();
                Destroy(other.gameObject);
            }
            //Destroy(other.gameObject);
        }

        else
        {

        }

    }

    // Update is called once per frame
    void Update () {

        if(end.strikes == 5)
        {

            return;
        }
		
	}
}
