using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMoving : MonoBehaviour
{
    [SerializeField]
    private float enemiesSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * enemiesSpeed * Time.deltaTime);
    }
}
