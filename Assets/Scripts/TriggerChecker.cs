using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");

        if(collision.gameObject.tag == "t1")
        {
            Debug.Log("trigger 1");
        }

        if (collision.gameObject.tag == "t2")
        {
            Debug.Log("trigger 2");
        }

        if (collision.gameObject.tag == "t3")
        {
            Debug.Log("trigger 3");
        }

        if (collision.gameObject.tag == "t4")
        {
            Debug.Log("trigger 4");
        }

        if (collision.gameObject.tag == "t5")
        {
            Debug.Log("trigger 5");
        }
    }
}
