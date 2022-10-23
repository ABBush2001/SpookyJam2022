using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void BeginGame()
    {
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        StartCoroutine(waitForLoad());
    }

    IEnumerator waitForLoad()
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(1);
    }
}
