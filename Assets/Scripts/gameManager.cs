using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject ReturnTrigger;

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
            
            
            
            miniGameCompleted = false;
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                GameObject.Find("Sub Noise").GetComponent<AudioSource>().Play();
                GameObject.Find("Main Camera").GetComponent<CameraFollow>().yOffset = 1f;
                GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
                StartCoroutine(changeScenes());
            }
            if(SceneManager.GetActiveScene().name == "ShipInterior")
            {
                GameObject.Find("Sub Noise").GetComponent<AudioSource>().Play();
                GameObject.Find("Main Camera").GetComponent<CameraFollow>().yOffset = 9f;
                ReturnTrigger.SetActive(true);
            }
        }
    }

    public void wrongMove(){
        correctedPipes -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator changeScenes()
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(1);
    }
}
