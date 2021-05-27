using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 10;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        this.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
