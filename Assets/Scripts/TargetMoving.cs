using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMoving : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 newPosition;
    [SerializeField] Animator animator;

    private bool isTimeToAttack;

    void Update()
    {
        Moving();
        AttackAnimation();
    }

    public bool IsTimeToAttack
    {
        get => isTimeToAttack;
    }

    private void Moving()
    {
        transform.position = Vector2.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
        if((Vector2)transform.position == newPosition)
        {
            isTimeToAttack = true;
            Debug.Log("Time to attack");
        }
    }

    public void AttackAnimation()
    {
        if(isTimeToAttack)
        {
            animator.SetTrigger("attack");
        }
    }
}
