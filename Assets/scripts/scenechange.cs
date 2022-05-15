using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenechange : MonoBehaviour
{

    public string scenename;
   void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scenename);
    }

}