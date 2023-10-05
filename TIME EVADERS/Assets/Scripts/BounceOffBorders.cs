using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOffBorders : MonoBehaviour
{
    private float minX, maxX, minY, maxY;

    public void SetBounds(float xMin, float xMax, float yMin, float yMax)
    {
        minX = xMin;
        maxX = xMax;
        minY = yMin;
        maxY = yMax;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Vector2 pos = collision.transform.position;
        Vector2 vel = collision.GetComponent<Rigidbody2D>().velocity;

        if (pos.x < minX)
        {
            pos.x = minX;
            vel.x = -vel.x;
        }
        else if (pos.x > maxX)
        {
            pos.x = maxX;
            vel.x = -vel.x;
        }

        if (pos.y < minY)
        {
            pos.y = minY;
            vel.y = -vel.y;
        }
        else if (pos.y > maxY)
        {
            pos.y = maxY;
            vel.y = -vel.y;
        }

        collision.transform.position = pos;
        collision.GetComponent<Rigidbody2D>().velocity = vel;
    }
}

