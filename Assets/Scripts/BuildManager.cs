using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    private GameObject turretToBuild;
    public GameObject standardTurretPrefab; // 1 (crab)
    public GameObject swordfish; // 2
    public GameObject lionfish; // 3
    public GameObject greatws; // 4
    public GameObject eel; // 5

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one build manager in scene");
            return;
        }
        instance = this;
    }
    
    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    public void crabchoice()
    {
        turretToBuild = standardTurretPrefab;
    }
    public void swordfishchoice()
    {
        turretToBuild = swordfish;
    }
    public void lionfishchoice()
    {
        turretToBuild = lionfish;
    }
    public void greatwschoice()
    {
        turretToBuild = greatws;
    }
    public void eelchoice()
    {
        turretToBuild = eel;
    }
}
