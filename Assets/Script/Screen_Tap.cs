using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen_Tap : MonoBehaviour
{
    public string sceneName;
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(sceneName);
        }

    }
}
