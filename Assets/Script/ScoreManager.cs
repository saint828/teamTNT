using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour {
    public TextMeshProUGUI score_text;
    void Update () {
        score_text.text = "Score:"+Player.score.ToString();
    }
}