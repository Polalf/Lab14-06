using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(x,0) * speed * Time.deltaTime;

       transform.position = new Vector3( Mathf.Clamp(transform.position.x, -10,10), transform.position.y, transform.position.z);
    }
}
