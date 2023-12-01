using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    [SerializeField] private float moveSpeed;
    private int pointsIndex;

    public GameObject routeFirst;
    public bool route1;

    public GameObject routeSecond;
    public bool route2;

    public GameObject routeThird;
    public bool route3;

    public GameObject routeFourth;
    public bool route4;




    public Animator animator;

    void Start()
    {
        routeFirst = GameObject.Find("Route1");
        routeSecond = GameObject.Find("Route2");
        routeThird = GameObject.Find("Route3");
        routeFourth = GameObject.Find("Route4");

        if (route1)
        {
            Points[0] = routeFirst.transform.Find("R1point1");
            Points[1] = routeFirst.transform.Find("R1point2");
            Points[2] = routeFirst.transform.Find("R1point3");
        }
        if (route2)
        {
            Points[0] = routeSecond.transform.Find("R2point1");
            Points[1] = routeSecond.transform.Find("R2point2");
            Points[2] = routeSecond.transform.Find("R2point3");
        }

        if (route3)
        {
            Points[0] = routeThird.transform.Find("R3point1");
            Points[1] = routeThird.transform.Find("R3point2");
            Points[2] = routeThird.transform.Find("R3point3");
        }

        if (route4)
        {
            Points[0] = routeFourth.transform.Find("R4point1");
            Points[1] = routeFourth.transform.Find("R4point2");
            Points[2] = routeFourth.transform.Find("R4point3");
        }

        transform.position = Points[pointsIndex].transform.position;
    }

    void Update()
    {
        if(pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);
            if(transform.position == Points[pointsIndex].transform.position)
            {
                pointsIndex += 1;
            }

            if(pointsIndex == Points.Length)
            {
                pointsIndex = 0;
            }
        }


        //Animations
        if (route1)
        {
            if (pointsIndex == 1)
            {
                animator.Play("EmuDown");
            }
            else if (pointsIndex == 2)
            {
                animator.Play("EmuUp");
            }
            else if (pointsIndex == 0)
            {
                animator.Play("EmuDownLeft");
            }
        }

        if (route2)
        {
            if (pointsIndex == 1)
            {
                animator.Play("EmuDownLeft");
            }
            else if (pointsIndex == 2)
            {
                animator.Play("EmuDown");
            }
            else if (pointsIndex == 0)
            {
                animator.Play("EmuUp");
            }
        }

        if (route3)
        {
            if (pointsIndex == 1)
            {
                animator.Play("EmuLeft");
            }
            else if (pointsIndex == 2)
            {
                animator.Play("EmuDownLeft");
            }
            else if (pointsIndex == 0)
            {
                animator.Play("EmuDown");
            }
        }

        if (route4)
        {
            if (pointsIndex == 1)
            {
                animator.Play("EmuUp");
            }
            else if (pointsIndex == 2)
            {
                animator.Play("EmuDown");
            }
            else if (pointsIndex == 0)
            {
                animator.Play("EmuDownLeft");
            }
        }
    }
}
