using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public GameObject propeller;
    private float rotationSpeed = 8000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the propeller clockwise (when viewed from rear)
         transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
    }
}
