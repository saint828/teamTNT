using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gacha_mawasu : MonoBehaviour
{
    int score;
    GameObject Error;
    // Start is called before the first frame update
    void Start()
    {
        score = Player.score;
        Error = GameObject.Find("error");
        Error.SetActive(false);
    }
}
