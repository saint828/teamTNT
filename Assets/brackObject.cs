using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち

public class brackObject : MonoBehaviour{
    public Image scoreGauge; // ゲージ本体画像をインスペクターからセット
    private float totalScore=100; // 得点を代入する変数
    public void punch(){
        totalScore = 0;
    }
    void Update()
    {
        scoreGauge.fillAmount = totalScore / 100.0f;
　　　　 // totalScoreを増減させるコードは今回は省略
    }
}