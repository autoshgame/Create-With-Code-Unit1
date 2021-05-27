using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed = 10f;
    [SerializeField]
    private float turnSpeed = 10f;
    private float horizontalMove;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        this.transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime);
        HorizontalMove();
    }

    void HorizontalMove()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        this.transform.Rotate(Vector3.up, turnSpeed * horizontalMove * Time.deltaTime);
    }
}
