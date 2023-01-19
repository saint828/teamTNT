using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち
public class PunchGage : MonoBehaviour
{
    public Image scoreGauge; // ゲージ本体画像をインスペクターからセット
    private float totalScore=0; // 得点を代入する変数
    float upDown = 1; // 得点を代入する変数

    public float punch(){
        return totalScore;
    }
    public void stop(){
        upDown=0;
    }
    void FixedUpdate()
    {
        scoreGauge.fillAmount = totalScore / 100.0f;
        totalScore += 1.0f * upDown;
        if(totalScore > 100)
        {
            upDown = -1;
        }else if(totalScore < 0)
        {
            upDown = 1;
        }
    }
}