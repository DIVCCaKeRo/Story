using UnityEngine;
using System.Collections;


public class Range : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }
    public GameObject explosion,temp;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Vuforia.DefaultTrackableEventHandler.Ready = true;
        }
        Vector3 Pos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(Mathf.Clamp(Pos.x, -8.0f, 8.0f), Mathf.Clamp(Pos.y, -1.0f, 18.0f), Mathf.Clamp(Pos.z,-15.0f ,0.0f ));             
    }
    void OnCollisionEnter(Collision test) 
    {
        if (test.gameObject.name == "Cylinder") 
        {
           temp= (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);
            
        }
    }
    void OnCollisionExit(Collision aaa)
    {
        if (aaa.gameObject.name == "Cylinder")
        {
            Renderer renderer = aaa.gameObject.GetComponent<Renderer>();
            renderer.material.color = Color.green;
            Destroy(temp);
        }

    }
    void OnCollisionStay(Collision aaa)
    {
        if (aaa.gameObject.name == "Cylinder")
        {
            Renderer renderer = aaa.gameObject.GetComponent<Renderer>();
            renderer.material.color = Color.yellow;
        }
            

    }
    
}
