using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissileBehaviour : MonoBehaviour
{
    private Renderer rnd;
    // Start is called before the first frame update
    void Start()
    {
        rnd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rnd.material.color = new Color(255, 0, 0);
    }
}
