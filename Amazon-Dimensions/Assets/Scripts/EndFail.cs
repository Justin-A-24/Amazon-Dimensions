using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFail : MonoBehaviour {

    public GameObject strike1, strike2, strike3;
    public Transform endpoint;
    public int strikes;

    public Text failText;

	// Use this for initialization
	void Start () {
        failText.text = "";
        strike1.GetComponent<GameObject>();
        strike2.GetComponent<GameObject>();
        strike3.GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (strikes == 1)
        {
            strike1.SetActive(true);
        }

        if (strikes == 2)
        {
            strike2.SetActive(true);
        }

        if (strikes == 3)
        {
            strike3.SetActive(true);
            failText.text = "You fucking suck";


        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        strikes = strikes + 1;
    }
}
