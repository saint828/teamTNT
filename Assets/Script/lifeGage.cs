using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち

public class lifeGage : MonoBehaviour
{
    public Image scoreGauge; // ゲージ本体画像をインスペクターからセット
    private float totalScore=75.0f; // 得点を代入する変数
    private float totalScoreBefor=100.0f; // 得点を代入する変数
    void damege(int damege){
        totalScore-=damege;
        if(totalScore<0){
            totalScore=0;
        }
    }
    void Update()
    {
        if(totalScore!=totalScoreBefor)
          scoreGauge.fillAmount = totalScore / 100.0f;
          totalScoreBefor=totalScore;
    }
}