using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] prefabs=new GameObject[5];
    public AudioClip[] clips = new AudioClip[4];
    float totalScore = 0;
    GameObject clone;
    void Start(){
        miniGameStart();
    }
    void miniGameStart(){
        int i = Random.Range(0,prefabs.Length);
        clone = Instantiate(prefabs[i], new Vector3(0.0f,2.0f,0.0f),Quaternion.identity);
    }
    public void gameOver(float score){
        totalScore += score;
        Destroy(clone,3.0f);
        miniGameStart();
    }
}
