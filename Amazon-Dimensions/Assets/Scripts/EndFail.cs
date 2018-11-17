using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFail : MonoBehaviour {

    public GameObject strike1, strike2, strike3, strike4, strike5;
    public Transform endpoint;

    public int strikes;

    public GameObject fired;

    public int gameTime;
    public Text timeText;

    public bool gameOver, gameWin;

	// Use this for initialization
	void Start () {
        strike1.GetComponent<GameObject>();
        strike2.GetComponent<GameObject>();
        strike3.GetComponent<GameObject>();
        strike4.GetComponent<GameObject>();
        strike5.GetComponent<GameObject>();

        fired.GetComponent<GameObject>();

        InvokeRepeating("Count", 0.0f, 1.0f);

        gameOver = false;
        gameWin = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        timeText.text = "Time Left:" + gameTime.ToString();

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
        }

        if (strikes == 4)
        {
            strike4.SetActive(true);
        }

        if (strikes == 5)
        {
            strike5.SetActive(true);
            fired.SetActive(true);
            gameOver = true;
        }

        if (gameOver == true)
        {
            return;
        }
        
        if (gameWin == true)
        {

        }
    }

    void Count()
    {
        if(gameTime == 0)
        {
            gameWin = true;
            CancelInvoke("Count");
        }

        else
        {
            gameTime--; 
        }


    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        strikes = strikes + 1;
    }
}
