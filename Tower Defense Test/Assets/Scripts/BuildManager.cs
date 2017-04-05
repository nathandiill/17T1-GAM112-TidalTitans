using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    private GameObject turretToBuild;
    public GameObject standardTurretPrefab;

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

}
