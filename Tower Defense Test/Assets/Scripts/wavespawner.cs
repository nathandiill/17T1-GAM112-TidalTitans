using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wavespawner : MonoBehaviour {

    public GameObject ScubaDiverPrefab;
    public GameObject CagePrefab;
    public GameObject OceanGliderPrefab;
    public GameObject BossPrefab;
    public Transform spawnpoint;
    public float timebetweenwaves = 5f;
    private float countdown = 2f;
    private int wavenumber = 1;
    public Text WaveText;
    public GameObject Manager;
    public Component GameManagerClass;
    private bool SpawnWaveOne = true;
    private bool SpawnWaveTwo = false;
    private bool SpawnWaveThree = false;

    void Start()
    {
        Manager = GameObject.Find("GameMaster");
    }

    void Update()
    {
        if (SpawnWaveOne == true)
        {
            StartCoroutine(WaveOne());
            SpawnWaveOne = false;
        }
        if (SpawnWaveTwo == true)
        {
            StartCoroutine(WaveTwo());
            SpawnWaveTwo = false;
        }
        if (SpawnWaveThree == true)
        {
            StartCoroutine(WaveThree());
            SpawnWaveThree = false;
        }
        WaveText.text = "Wave: " + wavenumber.ToString();
    }

    IEnumerator WaveOne()
    {
        for (int i = 0; i < 51; i++)
        {
            SpawnScubaDiver();
            yield return new WaitForSeconds(1f);
            if (i > 10 && i < 16)
            {
                SpawnCage();
            }
            yield return new WaitForSeconds(1f);
            if(i == 50)
            {
                SpawnWaveTwo = true;
                wavenumber = 2;
            }
        }
    }

    IEnumerator WaveTwo()
    {
        for (int i = 0; i < 51; i++)
        {
            SpawnScubaDiver();
            yield return new WaitForSeconds(0.7f);
            if (i > 10 && i < 21)
            {
                SpawnCage();
            }
            yield return new WaitForSeconds(0.7f);
            if (i > 15 && i < 21)
            {
                SpawnOceanGlider();
            }
            yield return new WaitForSeconds(0.7f);
            if (i == 50)
            {
                SpawnWaveThree = true;
                wavenumber = 3;
            }
        }
    }

    IEnumerator WaveThree()
    {
        for (int i = 0; i < 51; i++)
        {
            SpawnScubaDiver();
            yield return new WaitForSeconds(0.7f);
            if (i > 10 && i < 31)
            {
                SpawnCage();
            }
            yield return new WaitForSeconds(0.7f);
            if (i > 15 && i < 21)
            {
                SpawnOceanGlider();
            }
            yield return new WaitForSeconds(0.7f);
            if (i == 41)
            {
                SpawnBoss();
            }
        }
    }

    void SpawnScubaDiver()
    {
        Instantiate(ScubaDiverPrefab, spawnpoint.position, spawnpoint.rotation);

        //GameManagerClass += 1;

        // use this on the attack script so a sound can play for each sperate turret SoundManager.Instance.SparkyAudio();
    }
    void SpawnCage()
    {
        Instantiate(CagePrefab, spawnpoint.position, spawnpoint.rotation);
    }
    void SpawnOceanGlider()
    {
        Instantiate(OceanGliderPrefab, spawnpoint.position, spawnpoint.rotation);
    }
    void SpawnBoss()
    {
        Instantiate(BossPrefab, spawnpoint.position, spawnpoint.rotation);
    }
}
