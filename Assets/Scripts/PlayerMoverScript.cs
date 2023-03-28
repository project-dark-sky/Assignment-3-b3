using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoverScript : MonoBehaviour
{

    public AudioClip jumpSound;

    public float speed = 5f;
    public float jumpForce = 4;
    public Rigidbody2D rigidBody2D;
    public InputAction moveUp = new InputAction(type: InputActionType.Button);
    public InputAction moveRight = new InputAction(type: InputActionType.Button);
    public InputAction moveLeft = new InputAction(type: InputActionType.Button);
  



    // Start is called before the first frame update
    void Start()
    {
        moveUp.Enable();
        moveLeft.Enable();
        moveRight.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp.WasPerformedThisFrame())
        {
            AudioSource.PlayClipAtPoint(jumpSound, transform.position);
            rigidBody2D.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);   
        }
        if (moveRight.IsPressed())
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (moveLeft.IsPressed())
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }

    }
}
