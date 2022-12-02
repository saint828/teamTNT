using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち

public class punchGage : MonoBehaviour
{
    public Image scoreGauge; // ゲージ本体画像をインスペクターからセット
    private float totalScore; // 得点を代入する変数
    float upDown = 1; // 得点を代入する変数
    public brackObject brackObject;
    public void punch(){
        if(upDown!=0){
          upDown=0;
        }else{
            upDown=1;
        }
        brackObject.punch();
    }
    void Update()
    {
        scoreGauge.fillAmount = totalScore / 100.0f;
        totalScore += 0.3f * upDown;
        if(totalScore > 100)
        {
            upDown = -1;
        }else if(totalScore < 0)
        {
            upDown = 1;
        }
　　　　 // totalScoreを増減させるコードは今回は省略
    }
}