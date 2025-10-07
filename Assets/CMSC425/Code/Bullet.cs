using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 4f;
    public float lifeTime = 5f;
    public float timeLeft;
    public void Start()
    {
        timeLeft = lifeTime;
    }
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
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); // Destroy on impact
    }
}
