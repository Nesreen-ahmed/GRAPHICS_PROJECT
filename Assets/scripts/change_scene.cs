using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    public string LevelToLoad;
    public float timer = 5f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(LevelToLoad);
        }

    }
}