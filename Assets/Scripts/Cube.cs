using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float currentSpeed;

    [SerializeField] private float desactHeight = -5f;
    private void OnEnable()
    {
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * currentSpeed * Time.deltaTime;

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }
}
