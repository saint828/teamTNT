using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class touch_send : MonoBehaviour
{
    public int num;
    GameObject info;
    GameObject soubi;

    void Start(){
        info = GameObject.Find("info");
        soubi = GameObject.Find("soubi");
    }

    public void OnPointDown(){
        if(Player.check_having(num)){
            Player.equipment = num;
            Debug.Log(Player.equipment);
            info.SetActive(true);
            soubi.SetActive(true);
            soubi.GetComponent<Text>().text = Sord.return_swordname(num);
        }else{
            Debug.Log(Player.equipment);
        }
    }
    
}
