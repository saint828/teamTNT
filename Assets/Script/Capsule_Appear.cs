using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Capsule_Appear : MonoBehaviour
{
    float speed;
    bool showFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        this.speed = 4;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate(){
        this.transform.Translate(0,-this.speed/50,0);
    }

    void LateUpdate() { 
		if (GetComponent<Renderer>().isVisible) {
			showFlag = true;
		} else {
			if (showFlag) {
                SceneManager.LoadScene("mainGacha2");
				Destroy(this.gameObject);
			}
		}
	}
}
