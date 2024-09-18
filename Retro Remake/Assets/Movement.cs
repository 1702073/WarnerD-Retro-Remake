using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode jump = KeyCode.Space;

    public float speed = 10;
    public float jumpHeight = 15;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey() is for Holding a key
        //Input.GetKeyDown() is for Pressing a key
        //Input.GetKeyUp() is for Releasing a key

        if (Input.GetKey(left)) // Check for the player holding left
        {
            //get the Gameobjects's Rigidbody 2D component and set its velocity to the left at the given speed
            _rb.velocity = new Vector2(-speed, _rb.velocity.y);
        }

        if (Input.GetKey(right)) // Check for the player holding right
        {
            //get the Gameobjects's Rigidbody 2D component and set its velocity to the left at the given speed
            _rb.velocity = new Vector2(speed, _rb.velocity.y);
        }

        if (Input.GetKey(up))  // Check for the player holding up
        {
            //get the Gameobjects's Rigidbody 2D component and set its velocity to the left at the given speed
            _rb.velocity = new Vector2(_rb.velocity.x, speed );
        }

        if (Input.GetKey(down)) // Check for the player holding down
        {
            //get the Gameobjects's Rigidbody 2D component and set its velocity to the left at the given speed
            _rb.velocity = new Vector2(_rb.velocity.x, -speed);
        }

        if (Input.GetKeyDown(jump))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, speed * jumpHeight);
        }

        if (Input.GetKeyUp(jump))
        {
            _rb.velocity = new(_rb.velocity.x, _rb.velocity.y / 2) ;
        }

    }
}
