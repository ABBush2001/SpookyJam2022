using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Submarine").GetComponent<Rigidbody2D>().gravityScale = 0;
    }

}
