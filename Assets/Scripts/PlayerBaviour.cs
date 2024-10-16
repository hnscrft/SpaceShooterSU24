using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerBaviour : MonoBehaviour
{
    [SerializeField] float moveForce = 5f;

    [SerializeField] float maxBoostTime = 50f;
    [SerializeField] float boostMultiplier = 2;
    float playerHealth = 100f;
    float boostTime = 0f;

    bool isBoosting = false;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && boostTime != 0)
        {
            rb.AddForce(new Vector2(moveForce * boostMultiplier * Time.deltaTime * Input.GetAxisRaw("Horizontal"), moveForce * boostMultiplier * Time.deltaTime * Input.GetAxisRaw("Vertical")));
            boostTime -= 1 * Time.deltaTime;
            isBoosting = true;
        }

        else
        {
            rb.AddForce(new Vector2(moveForce * Time.deltaTime * Input.GetAxisRaw("Horizontal"), moveForce * Time.deltaTime * Input.GetAxisRaw("Vertical"))); //Moves player
            isBoosting = true;
            if (boostTime < maxBoostTime)
            {
                boostTime += 1 * Time.deltaTime;
            }
        }
    }
}
