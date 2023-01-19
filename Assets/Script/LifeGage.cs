using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeGage : MonoBehaviour
{
    public Image scoreGauge;
    private float totalScore=75.0f;
    private float maxLife=100.0f;
    public void reset(float firstLife)
    {
        totalScore=firstLife;
        maxLife=firstLife*4/3;
    }
    public int damage(float damege){
        totalScore-=damege*0.3f;
        if(totalScore<0){
            totalScore=0;
            scoreGauge.fillAmount = totalScore / maxLife;
            return 1;
        }
        scoreGauge.fillAmount = totalScore / maxLife;
        return 0;
    }
}