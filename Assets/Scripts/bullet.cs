using UnityEngine;

public class bullet : MonoBehaviour
{

    private Transform target;
    public float speed = 70f;
    public GameObject impactEffect;
    public GameObject EnemyTarget;
    public GameObject NewTarget;

    void Start()
    {
        EnemyTarget = GameObject.FindGameObjectWithTag("Enemy");
    }

    public void seek(Transform _target)
    {
        target = _target;
    }


    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distancethisframe = speed * Time.deltaTime;

        if (direction.magnitude <= distancethisframe)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distancethisframe, Space.World);

    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 5f);
        Damage(target);
        Destroy(gameObject);
    }
    void Damage (Transform enemy)
	{
		Enemy e = enemy.GetComponent<Enemy>();

		if (e != null)
		{
			e.TakeDamage();
		}
	}
}
