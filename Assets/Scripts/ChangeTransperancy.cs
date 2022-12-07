using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransperancy : MonoBehaviour
{
    public GameObject[] layers;
    public GameObject[] layers1;
    public GameObject[] layers2;
    public GameObject[] layers3;
    public GameObject[] layers4;
    public GameObject ground;
    public GameObject ground1;
    public GameObject ground2;
    public GameObject ground3;
    public GameObject ground4;
    public bool Trigger = false;
    public bool Trigger1 = false;
    public bool Trigger2 = false;
    public bool Trigger3 = false;
    public bool Trigger4 = false;
    void Start()
    {
        layers = GameObject.FindGameObjectsWithTag("Layer");
        layers1 = GameObject.FindGameObjectsWithTag("Layer1");
        layers2 = GameObject.FindGameObjectsWithTag("Layer2");
        layers3 = GameObject.FindGameObjectsWithTag("Layer3");
        layers4 = GameObject.FindGameObjectsWithTag("Layer4");
        if(ground != null) {
            ground = GameObject.FindWithTag("Ground");
        }
        if(ground1 != null) {
            ground1 = GameObject.FindWithTag("Ground1");
        }
        else if(ground2 != null) {
            ground2 = GameObject.FindWithTag("Ground2");
        }
        else if(ground3 != null) {
            ground3 = GameObject.FindWithTag("Ground3");
        }
        else if(ground4 != null) {
            ground4 = GameObject.FindWithTag("Ground4");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Trigger != false) {
            foreach (GameObject obj in layers)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0.5f;
                r.material.color = newColor;
            }
            Renderer r1 = ground.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0.5f;
            r1.material.color = newColor1;
        } else if(Trigger == false){
            foreach (GameObject obj in layers)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0;
                r.material.color = newColor;
            }
            Renderer r1 = ground.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0;
            r1.material.color = newColor1;
        }
        if(Trigger1 != false) {
            foreach (GameObject obj in layers1)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0.5f;
                r.material.color = newColor;
            }
            Renderer r1 = ground1.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0.5f;
            r1.material.color = newColor1;
        } else if(Trigger1 == false){
            foreach (GameObject obj in layers1)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0;
                r.material.color = newColor;
            }
            Renderer r1 = ground1.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0;
            r1.material.color = newColor1;
        }
        if(Trigger2 != false) {
            foreach (GameObject obj in layers2)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0.5f;
                r.material.color = newColor;
            }
            Renderer r1 = ground2.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0.5f;
            r1.material.color = newColor1;
        } else if(Trigger2 == false){
            foreach (GameObject obj in layers2)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0;
                r.material.color = newColor;
            }
            Renderer r1 = ground2.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0;
            r1.material.color = newColor1;
        }
        if(Trigger3 != false) {
            foreach (GameObject obj in layers3)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0.5f;
                r.material.color = newColor;
            }
            Renderer r1 = ground3.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0.5f;
            r1.material.color = newColor1;
        } else if(Trigger3 == false) {
            foreach (GameObject obj in layers3)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0;
                r.material.color = newColor;
            }
            Renderer r1 = ground3.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0;
            r1.material.color = newColor1;
        }
        if(Trigger4 != false) {
            foreach (GameObject obj in layers4)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0.5f;
                r.material.color = newColor;
            }
            Renderer r1 = ground4.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0.5f;
            r1.material.color = newColor1;
        } else if(Trigger4 == false) {
            foreach (GameObject obj in layers4)
            {
                Renderer r = obj.GetComponent<Renderer>();
                Color newColor = r.material.color;
                newColor.a = 0.0f;
                r.material.color = newColor;
            }
            Renderer r1 = ground4.GetComponent<Renderer>();
            Color newColor1 = r1.material.color;
            newColor1.a = 0.0f;
            r1.material.color = newColor1;
        }
    }

    public void OnTriggerEnter(Collider other) { 
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Layer")) {
            Trigger = true;
            Debug.Log("Layer1 Active");
        } else Trigger = false;
        if(other.gameObject.CompareTag("Ground1") || other.gameObject.CompareTag("Layer1")) {
            Trigger1 = true;
            Debug.Log("Layer2 Active");
        } else Trigger1 = false;
        if(other.gameObject.CompareTag("Ground2") || other.gameObject.CompareTag("Layer2")) {
            Trigger2 = true;
            Debug.Log("Layer3 Active");
        } else Trigger2 = false;
        if(other.gameObject.CompareTag("Ground3") || other.gameObject.CompareTag("Layer3")) {
            Trigger3 = true;
            Debug.Log("Layer4 Active");
        } else Trigger3 = false;
        if(other.gameObject.CompareTag("Ground4") || other.gameObject.CompareTag("Layer4")) {
            Trigger4 = true;
            Debug.Log("Layer5 Active");
        } else Trigger4 = false;
    }
}
