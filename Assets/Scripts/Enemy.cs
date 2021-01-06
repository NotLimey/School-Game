using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private GameObject _cloudParticlePrefab;

    public void Update()
    {
        if (transform.position.y > 10 ||
            transform.position.y < -8.40 ||
            transform.position.x > 14.40 ||
            transform.position.x < -14.40)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool didHitBird = collision.collider.GetComponent<birdBehaviour>() != null;
        if (didHitBird)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);

            Destroy(gameObject);
            return;
        }

        bool didHitGround = collision.collider.GetComponent<Ground>() != null;
        if (didHitGround)
        {
            Instantiate(_cloudParticlePrefab,
                transform.position,
                Quaternion.identity);
            Destroy(gameObject);
        }

        bool didHitOtherEnemy = collision.collider.GetComponent<Enemy>() != null;
        if (didHitOtherEnemy)
        {
            Instantiate(_cloudParticlePrefab,
                transform.position,
                Quaternion.identity);
            Destroy(gameObject);
        }

        if( collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_cloudParticlePrefab,
                transform.position,
                Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
