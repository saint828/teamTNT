using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha_Tap : MonoBehaviour
{
    int rotSpeed;
    public static int sum;
    public static bool isFinished;

    // Start is called before the first frame update
    void Start()
    {
        this.rotSpeed = 0;
        sum = 0;
        isFinished = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        rotSpeed = 8;
        GameObject.Find("TAP").SetActive(false);
    }

    void FixedUpdate(){
        if(sum == 360){
            rotSpeed = 0;
            isFinished = true;
        }else{
            sum += rotSpeed;
        }

        transform.Rotate(0,0,-rotSpeed);
    }
}
