using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 2f;
    [SerializeField] private Transform player;
    Vector3 playerPos;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPos = player.transform.position;
    }
    
    void Update()
    {
        DestroyWhenReached();
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, projectileSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
