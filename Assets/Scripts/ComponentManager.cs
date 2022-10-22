using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentManager : MonoBehaviour
{
    public static ComponentManager control;      // cheeky self-reference
    //public Texture2D texture;                    // our component reference

    void Awake()
    {
        control = this;                          // linking the self-reference
        DontDestroyOnLoad(transform.gameObject); // set to dont destroy
    }
}
