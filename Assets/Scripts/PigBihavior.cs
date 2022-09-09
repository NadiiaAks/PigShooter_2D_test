using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigBihavior : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject arrow;
    [SerializeField] Transform arrowSpot;
    [SerializeField] Transform arrowRotation;
    TargetMoving target;

    private bool isBullet;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").GetComponent<TargetMoving>();
    }


    private void Update()
    {
        if (target.IsTimeToAttack)
        {
            animator.SetTrigger("attack");
        }

        //MakeArrow();
    }

    /*private void MakeArrow()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(arrow, arrowSpot.position, arrowRotation.rotation);
        }
    }*/

}
