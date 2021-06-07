using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject player;
    public Camera camera1;
    public Camera camera2;
    private float xStable = 0f;
    private bool keypress = true;
    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        xStable = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && keypress == true)
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
    void LateUpdate()
    {
        camera1.transform.position = new Vector3(xStable, player.transform.position.y + 6, player.transform.position.z - 30);
        camera2.transform.position = player.transform.position + new Vector3(0, 3, -5);
    }
}
