using UnityEngine;
using System.Collections;

public class Range : MonoBehaviour {

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 Pos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(Mathf.Clamp(Pos.x, -4.7f, 4.7f), Mathf.Clamp(Pos.y, -0.2f, 1.7f), Mathf.Clamp(Pos.z,-4.7f ,0.3f ));             
    }
   // public GameObject Bullet;//子彈物件
    void OnCollisionEnter(Collision test) 
    {
        if (test.gameObject.name == "Cylinder") 
        {
           // Instantiate(gameObject, new Vector3(0.0f,3.0f,0.0f), Quaternion.identity);
            print("134564897987979488"); //在除錯視窗中顯示OK
        }
    }
}
