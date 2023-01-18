using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controll : MonoBehaviour
{
    GameObject showObject;
    bool flag;
    //public static bool animation_flag;

    // Start is called before the first frame update
    void Start()
    {
        showObject = GameObject.Find("Capsule");
        showObject.SetActive(false);
        flag = true;
        //animation_flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag){
            if(Gacha_Tap.isFinished){
                showObject.SetActive(true);
                this.flag = false;
            }
        }
    }
}
