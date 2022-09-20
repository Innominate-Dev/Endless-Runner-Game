using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Create a reference to the rigidbody2D so we can manipulate it

    public GameObject groundChecker;
    public LayerMask whatIsGround;

    private float speed = 3.0f;
    private float boost = 6.0f;
    public float jumpPower = 8000.0f;
    bool isOnGround = false;

    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //////////////////////////////// MOVEMENT SYSTEM //////////////////////////////////

        //Create a 'float' that will be equal to the playeres horizontal input
        float movementValueX = Input.GetAxis("Horizontal");

        //Change the X velocity of the Rigidbody2D to be equal to the movement value

        playerObject.velocity = new Vector2(movementValueX * speed, playerObject.velocity.y);

        ////////////////////////////// BOOST SYSTEM //////////////////////////////////////

        Debug.Log(playerObject.velocity.magnitude);

        if (Input.GetKey(KeyCode.LeftShift) && isOnGround == true && playerObject.velocity.magnitude > 0.01f)
        {
            StaminaBar.Instance.UseStamina(1); // DEDUCTS STAMINA FROM PLAYER TO REDUCE SPAMMING

            playerObject.AddForce(new Vector2(movementValueX * boost, playerObject.velocity.y));
        }
        
        ////////////////////////////////// JUMP SYSTEM ///////////////////////////////////
        
        //Check to see if the ground check is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.01f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            StaminaBar.Instance.UseStamina(15); // DEDUCTS STAMINA FROM PLAYER TO REDUCE SPAMMING

            playerObject.AddForce(new Vector2(0.0f, 300.0f));

            //////////////////////////// DOUBLE JUMP MECHANIC ///////////////////////////

            if (Input.GetKeyDown(KeyCode.Space) && isOnGround == false)
            {
                playerObject.AddForce(new Vector2(200.0f, 300.0f));
            }
        }
    }

}
