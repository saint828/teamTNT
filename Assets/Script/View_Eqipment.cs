using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View_Eqipment : MonoBehaviour
{
    public int number;
    string sword_name;

    void Start(){
        sword_name = "sord" + number.ToString();
    }

    void Update()
    {
        if(Player.check_having(number)){
            GameObject.Find(sword_name).GetComponent<Image>().sprite = Resources.Load<Sprite>(number.ToString());
        }else{
            GameObject.Find(sword_name).GetComponent<Image>().sprite = Resources.Load<Sprite>("Lock");
        }

    }
}
