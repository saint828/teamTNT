using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public AudioClip fireSound;
    public AudioClip waterSound;
    public AudioClip thunderSound;
    public AudioClip noneSound;
    AudioClip[] clips = new AudioClip[4];
    float totalScore = 0;
    GameObject clone;
    GameObject[] prefabs = new GameObject[5];
    void Start(){
        prefabs[0] = prefab;
        prefabs[1] = prefab1;
        prefabs[2] = prefab2;
        prefabs[3] = prefab3;
        prefabs[4] = prefab4;
        clips[0] = fireSound;
        clips[1] = waterSound;
        clips[2] = thunderSound;
        clips[3] = noneSound;
        miniGameStart();
    }
    void miniGameStart(){
        int i = Random.Range(0,5);
        clone = Instantiate(prefabs[i], new Vector3(0.0f,2.0f,0.0f),Quaternion.identity);
        i=Player.get_equipment();
        BreakObject breakObject = clone.GetComponent<BreakObject>();
        breakObject.swordSound = clips[i];

    }
    public void gameOver(float score){
        totalScore += score;
        Destroy(clone,3.0f);
        miniGameStart();
    }
}
