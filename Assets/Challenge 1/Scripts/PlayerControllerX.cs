using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //[SerializeField]
    private float speed = 60;
    //[SerializeField]
    private float rotationSpeed = 120;
    //[SerializeField]
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxisRaw("Vertical");

        // move the plane forward at a constant rate
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;

        // tilt the plane up/down based on up/down arrow keys
        Debug.Log(Vector3.left);
        this.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
