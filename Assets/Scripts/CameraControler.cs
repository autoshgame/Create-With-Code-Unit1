using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private float xStable = 0f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = player.transform.position + new Vector3(0, 7, -40);
        xStable = player.transform.position.x;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = new Vector3(xStable, player.transform.position.y + 7, player.transform.position.z - 40);
    }
}
