using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyNoiseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "NarwhalNoise")
        {
            collision.GetComponent<AudioSource>().Play();
        }
    }
}
