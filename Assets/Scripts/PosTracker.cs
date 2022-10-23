using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosTracker : MonoBehaviour
{
    public Vector2 pos;
    public bool posSet = false;

    private static PosTracker instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue manager in the scene!");
        }
        instance = this;
    }

    public static PosTracker GetInstance()
    {
        return instance;
    }

    void Update()
    {
        if(GameObject.Find("Submarine") != null)
        {
            pos.x = GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position.x;

            if (GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger1)
            {
                pos.y = GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position.y - 10;
                GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger1 = false;
                posSet = true;

            }

            if (GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger2)
            {
                pos.y = GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position.y - 10;
                GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger2 = false;
            }

            if (GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger3)
            {
                pos.y = GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position.y - 10;
                GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger3 = false;
            }

            if (GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger4)
            {
                pos.y = GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position.y - 10;
                GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger4 = false;
            }

            if (GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger5)
            {
                pos.y = GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position.y - 10;
                GameObject.Find("Submarine").GetComponent<TriggerChecker>().trigger5 = false;
            }

            /*for loading back in*/
            //between 1 and 2
            if (pos.y < GameObject.Find("Trigger1").transform.position.y && pos.y > GameObject.Find("Trigger2").transform.position.y && posSet == false)
            {
                GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position = pos;
                posSet = true;
            }

            //between 2 and 3
            if (pos.y < GameObject.Find("Trigger2").transform.position.y && pos.y > GameObject.Find("Trigger3").transform.position.y && posSet == false)
            {
                GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position = pos;
                posSet = true;
            }

            //between 3 and 4
            if (pos.y < GameObject.Find("Trigger3").transform.position.y && pos.y > GameObject.Find("Trigger4").transform.position.y && posSet == false)
            {
                GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position = pos;
                posSet = true;
            }

            //between 4 and 5
            if (pos.y < GameObject.Find("Trigger4").transform.position.y && pos.y > GameObject.Find("Trigger5").transform.position.y && posSet == false)
            {
                GameObject.Find("Submarine").GetComponent<Rigidbody2D>().position = pos;
                posSet = true;
            }
        }
        
    }

}
