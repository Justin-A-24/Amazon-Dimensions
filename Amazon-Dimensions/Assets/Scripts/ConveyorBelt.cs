using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour {

    public GameObject belt;
    public Transform endpoint;
    public float speed;

    public Animation anim;
    public AudioSource audi;

    public EndFail end;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objects"))
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
        }

    }
	
	// Update is called once per frame
	void Update () {
        
        if (end.strikes >= 5)
        {
            anim.gameObject.GetComponent<Animator>().enabled = false;
            audi.gameObject.GetComponent<AudioSource>().Stop();
        }
		
	}
}
