using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(transform);
        }
        
        else 
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    private void Start()
    {
       LoadScene("MainMenu");
    }

    // Update is called once per frame
    

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
