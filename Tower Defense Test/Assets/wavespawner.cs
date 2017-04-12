using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wavespawner : MonoBehaviour {

    public Transform enemyPrefab;
    public Transform spawnpoint;
    public float timebetweenwaves = 5f;
    private float countdown = 2f;
    private int wavenumber = 0;
    public Text WaveText;

    void Update()
    {
        if(countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timebetweenwaves;

        }
        countdown -= Time.deltaTime;
        WaveText.text = "Wave: " + wavenumber.ToString();
    }

    IEnumerator SpawnWave()
    {
        wavenumber++;
        for (int i = 0; i < wavenumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnpoint.position, spawnpoint.rotation);
    }
}
