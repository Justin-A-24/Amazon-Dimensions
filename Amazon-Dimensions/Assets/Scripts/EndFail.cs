using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFail : MonoBehaviour {

    public GameObject packagedObject;
    public Transform endpoint;
    public int strikes;

    public Text failText;

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        strikes = strikes + 1;
    }

	// Use this for initialization
	void Start () {
        failText.text = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (strikes == 3)
        {
            failText.text = "You fucking suck.";
        }
	}
}
