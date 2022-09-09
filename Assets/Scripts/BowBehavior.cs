using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowBehavior : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] GameObject pointPrefab;
    [SerializeField] GameObject[] points;
    [SerializeField] int numberOfPoints;
    [SerializeField] GameObject zeroObject;

    TargetMoving target;
    private Vector2 direction;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").GetComponent<TargetMoving>();
        points = new GameObject[numberOfPoints];
        for (int i = 0; i < numberOfPoints; i++)
        {
            points[i] = Instantiate(pointPrefab, zeroObject.transform.position, Quaternion.identity);
        }
    }

    public Vector2 GetDirection
    {
        get => direction;
    }
    void Update()
    {
        if (target.IsTimeToAttack)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 bowPos = zeroObject.transform.position;

            direction = mousePos - bowPos;

            FaceMous();

            for (int i = 0; i < points.Length; i++)
            {
                points[i].transform.position = PointPosition(i * 0.1f);
            }
        }
       
    }

    void FaceMous()
    {
        zeroObject.transform.right = direction;
    }

    Vector2 PointPosition(float t)
    {
        Vector2 currentPointPos = (Vector2)zeroObject.transform.position + (direction.normalized * force * t) + 0.5f * Physics2D.gravity * (t * t);
        return currentPointPos;
    }
}
