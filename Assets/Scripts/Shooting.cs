using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] float force;
    [SerializeField] Transform arrowPosition;
    GameObject newArrow;
    BowBehavior bow;
    TargetMoving target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").GetComponent<TargetMoving>();
        bow = GameObject.FindGameObjectWithTag("Bow").GetComponent<BowBehavior>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (target.IsTimeToAttack)
            {
                Shoot();
            }

        }
    }

    private void Shoot()
    {
        newArrow = Instantiate(arrow, arrowPosition.position, arrowPosition.rotation);

        newArrow.GetComponent<Rigidbody2D>().velocity = bow.GetDirection * force;
    }

}
