using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissileBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] float initialSpeed = 200f;
    [SerializeField] float luanchSpeed = 500f;
    [SerializeField] float fuse = 2f;
    [SerializeField] float spread = 20f;

    bool inPosition = false;
    bool hasCollided = false;
    bool hasLuanched = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, -initialSpeed));
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y <= 0)
        {
            if(inPosition == false)
            {
                rb.AddForce(new Vector2(0, initialSpeed));
                inPosition = true;
                Debug.Log("missile is in position");
            }
            fuse =- Time.deltaTime;
            if(fuse <= 0)
            {
                if (gameObject.transform.position.x < 0 && !hasCollided && !hasLuanched)
                {
                    rb.velocity = (new Vector2(luanchSpeed, Random.Range(-spread, spread)));
                    hasLuanched = true;
                }
                else if(gameObject.transform.position.x > 0 && !hasCollided && !hasLuanched)
                {
                    rb.velocity = (new Vector2(-luanchSpeed, Random.Range(-spread, spread)));
                    hasLuanched = true;
                }
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasCollided = true;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("Missile missed");
    }
}
