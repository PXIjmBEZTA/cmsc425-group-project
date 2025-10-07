using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Shooter : MonoBehaviour
{
    public Key shooterKey = Key.RightShift;
    public GameObject shot;

    KeyControl shootKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootKey = Keyboard.current[shooterKey];
    }

    // Update is called once per frame
    void Update()
    {
        if (shootKey.wasPressedThisFrame)
        {
            Instantiate(shot, transform.position + 1.6f * transform.forward + .5f * Vector3.up , transform.rotation);
        }
        
    }
}
