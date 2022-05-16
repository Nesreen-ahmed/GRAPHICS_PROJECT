using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenechange : MonoBehaviour
{

    public string scenename;

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
   void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scenename);
    }

}