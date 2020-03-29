using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectD : MonoBehaviour {

   
    GameObject mainCamera;

	// Use this for initialization
	void Start () {
        //オブジェクトの位置を取得する。

    
       
        mainCamera = GameObject.Find("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.z < mainCamera.transform.position.z)
        {
         

            Destroy(this.gameObject);

        }



	}
}
