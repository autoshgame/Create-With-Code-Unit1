using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = player.transform.position + new Vector3(0, 5, -15);
    }
    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = player.transform.position + new Vector3(0, 5, -15);
    }
}
