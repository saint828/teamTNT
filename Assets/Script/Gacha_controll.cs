using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha_controll : MonoBehaviour
{
    string sword_name;
    int rInt;
    // Start is called before the first frame update
    void Start()
    {
        rInt = Sord.return_swordnum();
        sword_name = Sord.return_swordname(rInt);
        Player.set_having(rInt);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("SordName").GetComponent<Text>().text = sword_name;
        GameObject.Find("Picture").GetComponent<Image>().sprite = Resources.Load<Sprite>(rInt.ToString());
    }
}
