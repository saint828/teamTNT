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
    void Start(){
        GameObject clone = Instantiate(prefab, new Vector3(0.0f,2.0f,0.0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
