using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaviour : MonoBehaviour
{
    [SerializeField] float rotationSpeed = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, rotationSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
        }
        
    }
}
