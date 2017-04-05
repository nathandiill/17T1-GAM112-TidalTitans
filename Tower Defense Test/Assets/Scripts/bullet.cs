using UnityEngine;

public class bullet : MonoBehaviour {

    private Transform target;
    public float speed = 70f;
    public GameObject impactEffect;
    public GameObject Enemy;
    private Enemy enemyscript;

    public void seek (Transform _target)
    {
        target = _target;
    }

    void Start()
    {
        enemyscript = Enemy.GetComponent<Enemy>();
    }
	
	// Update is called once per frame
	void Update () {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distancethisframe = speed * Time.deltaTime;

        if(direction.magnitude <= distancethisframe)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distancethisframe, Space.World);

	}

    void HitTarget()
    {
        GameObject effectins = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectins, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
