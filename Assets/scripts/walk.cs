using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public GameObject theNPC;
    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        if (Input.GetKey("up"))
        {
            theNPC.GetComponent<Animator>().Play("Walking");
        }
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        else if (Input.GetKey("down"))
        {
            theNPC.GetComponent<Animator>().Play("Walking Backwards");
        }
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        else if (Input.GetKey("left"))
        {
            theNPC.GetComponent<Animator>().Play("Left Strafe Walking");
        }
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        else if (Input.GetKey("right"))
        {
            theNPC.GetComponent<Animator>().Play("Right Strafe Walking");
        }
    }
}
