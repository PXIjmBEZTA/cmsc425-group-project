using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class MovePlayer : MonoBehaviour
{
    public float speed = 4;
    public Key forwardMove = Key.UpArrow;
    public Key backwardMove = Key.DownArrow;
    public Key leftMove = Key.LeftArrow;
    public Key rightMove = Key.RightArrow;

    KeyControl forwardKey;
    KeyControl backwardKey;
    KeyControl leftKey;
    KeyControl rightKey;   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forwardKey = Keyboard.current[forwardMove];
        backwardKey = Keyboard.current[backwardMove];
        leftKey = Keyboard.current[leftMove];
        rightKey = Keyboard.current[rightMove];
    }

    // Update is called once per frame
    void Update()
    {
        if (forwardKey.isPressed)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (backwardKey.isPressed)
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if (leftKey.isPressed)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (rightKey.isPressed)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
