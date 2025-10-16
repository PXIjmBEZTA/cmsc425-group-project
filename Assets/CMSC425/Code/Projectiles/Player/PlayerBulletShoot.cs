using UnityEngine;

public class PlayerBulletShoot : MonoBehaviour, IPlayerBullet
{
    public float speed;
    public float lifeTime;
    public float timeLeft;
    [SerializeField] private int damage;
    public int Damage => damage;
    void Start()
    {
        speed = 3.0f;
        lifeTime = 5f;
        damage = 2;
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

    private void OnTriggerEnter(Collider other)
    {
        IEnemy enemy = other.GetComponent<IEnemy>();
        var takeDamage = other.GetComponent<EnemyTakeDamage>();
        if (enemy != null)
        {
            Destroy(gameObject);
        }


    }
}
