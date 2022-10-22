using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject pipeHolder;
    public GameObject[] Pipes;
    public bool miniGameCompleted = false;
    public GameObject pipMiniGame;

    public int correctedPipes = 0;

    
    public int totalPipes = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalPipes = pipeHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for(int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = pipeHolder.transform.GetChild(i).gameObject;
        }
        
    }

    public void correctMove(){
        correctedPipes += 1;

        if(correctedPipes == totalPipes)
        {
            Debug.Log("You win!");
            miniGameCompleted = true;
            pipMiniGame.SetActive(false);
            GameObject.Find("Main Camera").GetComponent<CameraFollow>().yOffset = 1f;
        }
    }

    public void wrongMove(){
        correctedPipes -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
