using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
    public Vector3 point;
    public float rotSpeed = 300.0f;
    GameObject pivot_cube;

    void Start()
    {
        pivot_cube = GameObject.FindWithTag("Pivot");
        
        //Getting Data ----------------------------------------------
        
        //Get Children
        //List<Transform> children = GetChildren(transform, false);

        //Get Children Recursively
        //List<Transform> children = GetChildren(transform, true);

        //Get Children Hierarchy
        //Dictionary<Transform, dynamic> children = GetChildrenHierarchy(transform);
        
        //Children Extension Method
        List<Transform> children = gameObject.GetChildren(true);
        //Dictionary<Transform, dynamic> children = gameObject.GetChildrenHierarchy();
        
        //Unity Array (also include parent)
        //Transform[] children = gameObject.GetComponentsInChildren<Transform>();
        
        //Accessing Data -----------------------------------
        
        //List
        
        //Dictionary
        //ReadChildHierarchy(children);
         
        foreach(Transform child in children) {
            Debug.Log(child.name);
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey(KeyCode.LeftArrow)) {
            pivot_cube.transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow)) {
            pivot_cube.transform.Rotate(-Vector3.up, rotSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.UpArrow)) {
            pivot_cube.transform.Rotate(Vector3.right, rotSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.DownArrow)) {
            pivot_cube.transform.Rotate(-Vector3.right, rotSpeed * Time.deltaTime);
        }
    }
    List<Transform> GetChildren(Transform parent, bool resursive) {
        List<Transform> children = new List<Transform>();

        foreach(Transform child in parent) {
            children.Add(child);
            if(resursive) {
                children.AddRange(GetChildren(child, true));
            }
        }
        return children;
    }
    Dictionary<Transform, dynamic> GetChildrenHierarchy(Transform parent) {
        Dictionary<Transform, dynamic> children = new Dictionary<Transform, dynamic>();

        foreach(Transform child in parent) {
            children.Add(child, GetChildrenHierarchy(child));
        }
        return children;
    }
    void ReadChildHierarchy(Dictionary<Transform, object> hierarchy) {
        foreach(KeyValuePair<Transform, object> child in hierarchy) {
            Debug.Log(child.Key);
            
            if(child.Value != null) {
                ReadChildHierarchy((Dictionary<Transform, object>)child.Value);
            }
        }
    }
}
//https://www.youtube.com/watch?v=KhvokgokrQE&ab_channel=Danndx