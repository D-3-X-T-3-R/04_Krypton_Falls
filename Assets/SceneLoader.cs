using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start()
    {
        
        //Invoke("LoadNextScene", 5f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("LoadNextScene", 2f);
        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
