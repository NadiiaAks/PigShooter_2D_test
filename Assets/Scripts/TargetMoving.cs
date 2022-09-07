using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMoving : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 newPosition;

    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        transform.position = Vector2.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
    }
}
