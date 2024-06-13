using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    CharacterController characterController;
    PlayerGravity playerGravity;
    Transform camTransform, throwPoint;
    Weapon weapon;
    Vector2 camDirection;
    Vector3 direction;
    const float speed = 5;
    float verticalRotation, mouseSensitivity;
    bool shooting, crouching;
    GameObject grenade;

    void Awake ()
    {   
        Cursor.lockState = CursorLockMode.Locked; // Trava o cursor no centro da tela

        // Obtém o componente CharacterController anexado ao GameObject
        characterController = GetComponent<CharacterController>();
        // Obtém o primeiro filho do GameObject (a câmera)
        camTransform = transform.GetChild(0).GetComponent<Transform>();
       // playerGravity = GetComponent<PlayerGravity>();
       // weapon = GetComponentInChildren<Weapon>(); */
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");


        Movement();
        Rotation();
        Fire();
    }

    void Movement()
    {

    }

    void Rotation()
    {

    }

    void Fire()
    {

    }

    void Jump()
    {

    }

    void Crouch()
    {

    }

    void ThrowGrenade()
    {

    }

    public class PlayerGravity
    {

    }
}
