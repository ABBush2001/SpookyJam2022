using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnToSub : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "ReturnTrigger")
        {
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            GameObject.Find("EventSystem").GetComponent<PosTracker>().posSet = false;
            StartCoroutine(changeScenes());
        }
    }

    IEnumerator changeScenes()
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(2);
    }
}
