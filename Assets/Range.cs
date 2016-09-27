using UnityEngine;
using System.Collections;

public class Range : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }
    public GameObject explosion,temp;
	// Update is called once per frame
	void Update () {
        Vector3 Pos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(Mathf.Clamp(Pos.x, -4.7f, 4.7f), Mathf.Clamp(Pos.y, -0.2f, 3.7f), Mathf.Clamp(Pos.z,-4.7f ,0.3f ));             
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
