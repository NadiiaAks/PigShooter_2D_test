using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] float force;
    [SerializeField] Transform arrowPosition;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject newArrow = Instantiate(arrow, arrowPosition.position, arrowPosition.rotation);

        newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * force;
    }
}
