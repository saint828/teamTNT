using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touch_send : MonoBehaviour
{
    public int num;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(Player.check_having(num)){
                Player.equipment = num;
                //Debug.Log(Player.equipment);
                SceneManager.LoadScene("GameTopScene");
            }
        }
            
        

    }
    
}
