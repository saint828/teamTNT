using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <--忘れがち

public class BreakObject : MonoBehaviour{
    public LifeGage LifeGage;
    public PunchGage PunchGage;
    public SpriteChange SpriteChange;
    [SerializeField] private Sprite NextSprite;
    public AudioClip highPunch;
    public AudioClip middlePunch;
    public AudioClip lowPunch;
    public AudioClip breakSound;
    public AudioClip swordSound;
    [SerializeField] AudioSource[] audioSource;

    public void Start()
    {

    }
    public void touch(){
        float punchDamage=PunchGage.punch();
        if(LifeGage.damage(punchDamage)==1){
            broken();

        }
        if(punchDamage>0.7f){
            audioSource[0].PlayOneShot(highPunch);
        }else if(punchDamage>0.3f){
            audioSource[0].PlayOneShot(middlePunch);
        }else{
            audioSource[0].PlayOneShot(lowPunch);
        }
        audioSource[1].PlayOneShot(swordSound);
    }
    void broken(){
        SpriteChange.OnClick(NextSprite);
        PunchGage.stop();
        audioSource[2].PlayOneShot(breakSound);
    }
}