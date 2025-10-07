using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Turner : MonoBehaviour
{
    public Key rightTurn = Key.RightArrow;
    public Key leftTurn = Key.LeftArrow;
    public float rpm = 10;

    KeyControl rightKey;
    KeyControl leftKey;
    float dps;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rightKey = Keyboard.current[rightTurn];
        leftKey = Keyboard.current[leftTurn];
        dps = 6 * rpm;
    }

    // Update is called once per frame
    void Update()
    {
        if (rightKey.isPressed)
        {
            transform.Rotate(0, Time.deltaTime * dps, 0);
        }

        if (leftKey.isPressed)
        {
            transform.Rotate(0, -Time.deltaTime * dps, 0);
        }
    }
}
