using UnityEngine;

public class TakeHit : MonoBehaviour
{
    System.Random rand = new System.Random();

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        transform.position = new Vector3(R(5), 0, R(5));
        transform.eulerAngles = new Vector3(0, R(180), 0);
    }

    float R(float m)
    {
        return 2 * (float)(rand.NextDouble() - .5f) * m;
    }
}
