using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerOverflow : MonoBehaviour {

    int bigNumber = 2147483640;

    // Use this for initialization
    void Start()
    {

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(bigNumber);
        bigNumber = bigNumber + 1;
	}
}
