using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち

public class BreakObject : MonoBehaviour{
    public SpriteChange SpriteChange;
    public lifeGage lifeGage;
    public int damege(float damege){
        int temp= lifeGage.damege(damege);
        if(temp==1){
            SpriteChange.OnClick();
        }
        return temp;
    }
}