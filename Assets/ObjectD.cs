using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectD : MonoBehaviour {

   
    GameObject unitychan;

	// Use this for initialization
	void Start () {
        //オブジェクトの位置を取得する。

    
       
        unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.z < unitychan.transform.position.z)
        {
         

            Destroy(this.gameObject);

        }



	}
}
