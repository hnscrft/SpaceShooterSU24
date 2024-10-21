using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissileBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, -30));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("Missile missed");
   }
}
