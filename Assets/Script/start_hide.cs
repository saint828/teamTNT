using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_hide : MonoBehaviour
{
    GameObject hide;
    public string target;
    
    void Start()
    {
        hide = GameObject.Find(target);
        hide.SetActive(false);
    }
}
