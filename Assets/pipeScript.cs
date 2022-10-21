using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float[] rotations = {0, 90, 180, 270};

    public float[] correctRotation;
    public bool isPlaced = false;

    int PossibleRots = 1;

    gameManager gameManager;

    private void Awake(){
        gameManager = GameObject.Find("gameManager").GetComponent<gameManager>();
    }

    private void Start()
    {
        PossibleRots = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0,0,rotations[rand]);

        if(PossibleRots > 1){
            if(transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] )
            {
                isPlaced = true;
                gameManager.correctMove();
            }
        }
        else if(transform.eulerAngles.z == correctRotation[0]){
            isPlaced = true;
            gameManager.correctMove();
        }
        
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0,0,90));
        if(PossibleRots > 1){
            if(transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
            else if(isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }
        else{
            if(transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
            else if(isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }
        
    }
}
