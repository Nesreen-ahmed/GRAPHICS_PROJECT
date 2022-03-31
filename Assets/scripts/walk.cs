using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public GameObject theNPC;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            theNPC.GetComponent<Animator>().Play("Walking");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            theNPC.GetComponent<Animator>().Play("Walking Backwards");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            theNPC.GetComponent<Animator>().Play("Left Strafe Walking");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            theNPC.GetComponent<Animator>().Play("Right Strafe Walking");
        }
    }
}
