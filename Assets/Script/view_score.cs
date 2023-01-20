using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class view_score : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = Player.score;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Score").GetComponent<Text>().text = score.ToString();
    }
}
