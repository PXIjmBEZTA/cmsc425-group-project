using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Mover : MonoBehaviour
{
    public float speed = 2;
    public Key forwardMove = Key.UpArrow;
    public Key backwardMove = Key.DownArrow;

    KeyControl forwardKey;
    KeyControl backwardKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forwardKey = Keyboard.current[forwardMove];
        backwardKey = Keyboard.current[backwardMove];
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
    }
}
