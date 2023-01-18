using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち

public class BreakObject : MonoBehaviour{
    public SpriteChange SpriteChange;
    public lifeGage lifeGage;
    public PunchGage PunchGage;
    public GameObject clicked_object;
    public AudioClip clip; // AudioSourceのAudioClipに選択されている音データを格納

    public void touch(){
        float punchDamage=PunchGage.punch();
        if(lifeGage.damage(punchDamage)==1){
            SpriteChange.OnClick();
            PunchGage.stop();
        }
        clip = clicked_object.GetComponent<AudioSource>().clip;
        Debug.Log(clip);
        clicked_object.GetComponent<AudioSource>().PlayOneShot(clip);
        Debug.Log("You clicked.");
    }
}