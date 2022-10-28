using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ChangeGachaScene()
    {
        SceneManager.LoadScene("GachaScene");
    }
}
