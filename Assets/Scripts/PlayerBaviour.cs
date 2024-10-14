using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaviour : MonoBehaviour
{
    [SerializeField] float moveForce = 5f;
    [SerializeField] float boostTime = 50f;
    [SerializeField] float boostMultiplier = 2;

    bool isBoosting = false;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isBoosting = Input.GetKey(KeyCode.Space);
    }

    // Update is called once per frame
    void Update()
    {
        if(isBoosting == false)
        {
            rb.AddForce(new Vector2(moveForce * Time.deltaTime * Input.GetAxisRaw("Horizontal"), moveForce * Time.deltaTime * Input.GetAxisRaw("Vertical"))); //Moves player
        }
        else if (isBoosting == true && boostTime != 0)
        {
            rb.AddForce(new Vector2( moveForce * boostMultiplier * Time.deltaTime * Input.GetAxisRaw("Horizontal"), moveForce * boostMultiplier * Time.deltaTime * Input.GetAxisRaw("Vertical")));
            boostTime -= 1 * Time.deltaTime;
        }
    }
}
