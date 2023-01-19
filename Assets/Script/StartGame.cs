using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public GameObject[] prefabs=new GameObject[5];
    public AudioClip[] clips = new AudioClip[4];
    GameObject clone;
    void Start(){
        miniGameStart();
    }
    void miniGameStart(){
        int i = Random.Range(0,prefabs.Length);
        clone = Instantiate(prefabs[i], new Vector3(0.0f,2.0f,0.0f),Quaternion.identity);
    }
    public async void gameOver(float score){
        Player.score += (int)(score/1000);
        Destroy(clone,1.5f);
        await Task.Delay(1500);
        if(SceneManager.GetActiveScene().name=="MainScene"){
            miniGameStart();
        }
    }
}
