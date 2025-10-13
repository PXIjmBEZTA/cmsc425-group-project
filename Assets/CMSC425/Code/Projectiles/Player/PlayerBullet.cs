using UnityEngine;

public class PlayerBulletShoot : MonoBehaviour
{
    public float speed = 3.0f;
    public float lifeTime = 5f;
    public float timeLeft;
    void Start()
    {
        timeLeft = lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
