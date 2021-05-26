using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    private float horizontalMove;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Run();
    }

    void Run()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        this.transform.Translate((float)(horizontalMove * 0.6), 0, 0);
    }
}
