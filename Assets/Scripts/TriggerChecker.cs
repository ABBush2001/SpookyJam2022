using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "t1")
        {
            Debug.Log("trigger 1");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t2")
        {
            Debug.Log("trigger 2");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t3")
        {
            Debug.Log("trigger 3");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t4")
        {
            Debug.Log("trigger 4");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            StartCoroutine(waitForFade(collision));
        }

        if (collision.gameObject.tag == "t5")
        {
            Debug.Log("trigger 5");
            GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
            StartCoroutine(waitForFade(collision));
        }
    }

    IEnumerator waitForFade(Collider2D collision)
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("Submarine").transform.SetPositionAndRotation(new Vector3(-6.8829f, collision.transform.position.y - 10, 0), new Quaternion());
        GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(2);
    }
}
