using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wavespawner : MonoBehaviour {

    public GameObject ScubaDiverPrefab;
    public GameObject CagePrefab;
    public GameObject BossPrefab;
    public Transform spawnpoint;
    public float timebetweenwaves = 5f;
    private float countdown = 2f;
    private int wavenumber = 0;
    public Text WaveText;
    public GameObject Manager = GameObject.Find("GameMaster");
    public Component GameManagerClass;

   
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
            if(wavenumber >= 5)
            {
                SpawnCage();
                yield return new WaitForSeconds(0.8f);
            }
            if(wavenumber == 10)
            {
                Instantiate(BossPrefab, spawnpoint.position, spawnpoint.rotation);
            }
        }
    }

    void SpawnEnemy()
    {
        Instantiate(ScubaDiverPrefab, spawnpoint.position, spawnpoint.rotation);
        //GameManagerClass += 1;

        // use this on the attack script so a sound can play for each sperate turret SoundManager.Instance.SparkyAudio();
   
    }
    void SpawnCage()
    {
        Instantiate(CagePrefab, spawnpoint.position, spawnpoint.rotation);
    }
    //void SpawnBoss()
    //{
    //    Instantiate(BossPrefab, spawnpoint.position, spawnpoint.rotation);
    //}
}
