using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComponentManager : MonoBehaviour
{
    private static ComponentManager instance;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
