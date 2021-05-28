using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed = 50f;
    [SerializeField]
    private float turnSpeed = 60f;
    private float horizontalMove;
    void HorizontalMove()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        this.transform.Rotate(Vector3.up, turnSpeed * horizontalMove * Time.deltaTime);
    }

   void VerticalMove()
    {
        this.transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticalMove();
        HorizontalMove();
    }

    
}
