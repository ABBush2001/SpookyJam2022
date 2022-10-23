using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public GameObject creature;
    
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJson;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if(playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if(InputManager.GetInstance().GetInteractPressed())
            {
                //end game
                creature.SetActive(true);
                GameObject.Find("Jumpscare").GetComponent<AudioSource>().Play();
                
                StartCoroutine(LoadCredits());
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    IEnumerator LoadCredits()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().speedScale = 40;
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(5);
        GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(4);
    }
}
