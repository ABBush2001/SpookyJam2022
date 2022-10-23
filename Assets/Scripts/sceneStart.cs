using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneStart : MonoBehaviour
{
    // Start is called before the first frame update

    public float pos;
    public GameObject light;
    public GameObject creature1;
    public GameObject creature2;
    public GameObject creature3;
    public GameObject creature4;
    public GameObject creature5;

    //GameObject es = GameObject.Find("EventSystem").GetComponent<PosTracker>();
    void Start()
    {
        pos = GameObject.Find("EventSystem").GetComponent<PosTracker>().pos.y;
        if(pos < -19.00 && pos > -64.00){
            //first scene
            Debug.Log("first scene");
            light.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1;
            creature1.SetActive(true);

        }
        else if(pos < -64.00 && pos > -120.00){
            //second scene
            Debug.Log("second scene");
            light.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = .8f;
            creature2.SetActive(true);
        }
        else if(pos < -120.00 && pos > -200.00){
            //third scene
            Debug.Log("third scene");
            light.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = .6f;
            creature3.SetActive(true);
        }
        else if(pos < -200.00 && pos > -300.00){
            //fourth scene
            Debug.Log("fourth scene");
            light.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = .4f;
            creature4.SetActive(true);
        }
        else{
            //fifth scene
            Debug.Log("fifth scene");
            light.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = .1f;
            light.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
