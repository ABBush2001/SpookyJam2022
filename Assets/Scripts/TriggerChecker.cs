using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerChecker : MonoBehaviour
{
    public bool trigger1 = false;
    public bool trigger2 = false;
    public bool trigger3 = false;
    public bool trigger4 = false;
    public bool trigger5 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "t1")
        {
            Debug.Log("trigger 1");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            trigger1 = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t2")
        {
            Debug.Log("trigger 2");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            trigger2 = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t3")
        {
            Debug.Log("trigger 3");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            trigger3 = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t4")
        {
            Debug.Log("trigger 4");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            trigger4 = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t5")
        {
            Debug.Log("trigger 5");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            trigger5 = true;
            StartCoroutine(waitForFade(collision));
        }
    }

    IEnumerator waitForFade(Collider2D collision)
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(3);
    }
}
