using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mawasu_buttorn : MonoBehaviour
{
    GameObject Error;

    void Start()
    {
        Error = GameObject.Find("error");
    }

    public void OnMouseDown(){
        if(Player.score >= 100){
            Player.score -= 100;
            SceneManager.LoadScene("mainGacha");
        }else{
            Error.SetActive(true);
        }
    }
}
