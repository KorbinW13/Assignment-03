using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public SpriteRenderer rotatorSprite;
    private float speed = KeepData.RotatorSpeed;
    
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    void Start()
    { 
        switch (KeepData.ColorNumber)
        {
            case 0:
                rotatorSprite.color = Color.black;
                break;
            case 1:
                rotatorSprite.color = Color.blue;
                break;
            case 2:
                rotatorSprite.color = Color.red;
                break;
        }
    }
}
