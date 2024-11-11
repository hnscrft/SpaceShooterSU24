using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantatiateTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GameObject.FindGameObjectWithTag("Enemy"), new Vector3(-30, 20, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
