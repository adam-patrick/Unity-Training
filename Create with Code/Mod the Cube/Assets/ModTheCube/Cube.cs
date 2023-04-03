using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject currentGameObject;
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 2, 1);
        transform.localScale = Vector3.one * 2.0f;
        
        Material material = Renderer.material;
        material.color = new Color (10, 1, 5, 1);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
