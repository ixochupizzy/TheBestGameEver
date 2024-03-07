using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float lifetime;
    public float speed;
    public float damage = 10;
    // Start is called before the first frame update
    private void Start()
    {
        Invoke("DestroyFireBall", lifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovefixedUpdate();
    }
    private void MovefixedUpdate() 
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyFireBall();
        DamageEnemy(collision);
    }
    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }


    private void DestroyFireBall()
    {
        Destroy(gameObject);
    }

}
