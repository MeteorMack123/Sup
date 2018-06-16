using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    int count = 0;
    int count2 = 0;
    List<int> faker = new List<int>();

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Hello world");
        count = faker[1];
    }
	
	// Update is called once per frame
	void Update ()
    {
        count++;

        if (count > 30)
        {
            count = 0;
            count2++;
            Debug.Log("count2" + count2);
        }
	}
}
