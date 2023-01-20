using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sord : MonoBehaviour
{
    public static string[] Sord_Name = {"Fire Sword","Water Sword","Thunder Sword","ordinal Sword"};

    public static int return_swordnum(){
        int rInt = Random.Range(0, 3);
        return rInt;
    }

    public static string return_swordname(int rInt){
        return Sord_Name[rInt];
    }
}
