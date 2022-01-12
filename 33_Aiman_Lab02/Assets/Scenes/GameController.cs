using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Cube0;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject Cube6;
    public GameObject Cube7;
    public GameObject Cube8;

    private int turnCounter;
    // Start is called before the first frame update
    void Start()
    {
        Cube0.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube1.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube2.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube3.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube4.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube5.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube6.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube7.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube8.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        // Getting user input//
        //1st row of inputs //
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //check if cube is white color //
            if (Cube0.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number//
                if (turnCounter % 2 == 1)
                {
                    // change color to red//
                    Cube0.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    // change color to green//
                    print("Player 2 Turn");
                    Cube0.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;

                
              
            }

        }
    }
}
