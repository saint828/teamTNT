using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Button : MonoBehaviour
{
    public string sceneName;

    public void OnMouseDown(){
        SceneManager.LoadScene(sceneName);
    }
}
