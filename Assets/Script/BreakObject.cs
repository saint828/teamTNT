using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakObject : MonoBehaviour{
    public LifeGage LifeGage;
    public PunchGage PunchGage;
    public SpriteChange SpriteChange;
    [SerializeField] private Sprite NextSprite;
    public AudioClip highPunch;
    public AudioClip middlePunch;
    public AudioClip lowPunch;
    public AudioClip breakSound;
    public StartGame StartGame;
    [SerializeField] AudioSource[] audioSource;
    AudioClip swordSound;
    int brokenCount=0;
    float score=0;
    float punchVolume;
    public void Start()
    {
        StartGame=GameObject.Find("StartScript").GetComponent<StartGame>();
        int i= Player.get_equipment();
        swordSound=StartGame.clips[i];
    }
    public void touch(){
        float punchDamage=PunchGage.punch();
        score+=(punchDamage)*(punchDamage)*(punchDamage);
        punchVolume = punchDamage / 10;
        if(LifeGage.damage(punchDamage)==1){
            broken();

        }else{
            if(punchDamage>0.7f){
                audioSource[0].PlayOneShot(highPunch, punchVolume);
            }else if(punchDamage>0.3f){
                audioSource[0].PlayOneShot(middlePunch, punchVolume);
            }else{
                audioSource[0].PlayOneShot(lowPunch, punchVolume);
            }
            audioSource[1].PlayOneShot(swordSound);
        }
    }
    void broken(){
        if(brokenCount==0){
            brokenCount++;
            SpriteChange.OnClick(NextSprite);
            PunchGage.stop();
            audioSource[2].PlayOneShot(breakSound, punchVolume);
            StartGame.gameOver(score);
            return;
        }
    }
}