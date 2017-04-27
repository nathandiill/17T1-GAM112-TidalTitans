
using UnityEngine;

public class node : MonoBehaviour {

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    public GameObject turret;
    private Vector3 turretposition;
    public float selectedTower_Cost;
    public GameObject currentTurret;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        turretposition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }
    void Update()
    {

    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void OnMouseDown()
    {
        if(turret != null)
        {
            Destroy(turret.gameObject);
            return;
        }
        //Build a turret
        GameObject turretTo_Build = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretTo_Build, turretposition, transform.rotation);
    }
}
