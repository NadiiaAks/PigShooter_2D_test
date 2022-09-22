using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMoving : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 newPosition;

    private bool isTimeToAttack;
    private int scoreKeeper = 0;

    void Update()
    {
        Moving();
    }

    public bool IsTimeToAttack
    {
        get => isTimeToAttack;
    }
     public int ScoreKeeper
    {
        get => scoreKeeper;
    }

    private void Moving()
    {
        transform.position = Vector2.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);

        if((Vector2)transform.position == newPosition)
        {
            isTimeToAttack = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreKeeper++;
        Destroy(collision.gameObject);
    }

}
