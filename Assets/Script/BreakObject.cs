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
    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void touch(){
        float punchDamage=PunchGage.punch();
        if(LifeGage.damage(punchDamage)==1){
            SpriteChange.OnClick(NextSprite);
            PunchGage.stop();
        }
        if(punchDamage>0.7f){
            audioSource.PlayOneShot(highPunch);
        }else if(punchDamage>0.3f){
            audioSource.PlayOneShot(middlePunch);
        }else{
            audioSource.PlayOneShot(lowPunch);
        }
    }
}