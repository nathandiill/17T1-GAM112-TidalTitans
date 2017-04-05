
using UnityEngine;

public class node : MonoBehaviour {

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Destroy(turret.gameObject);
            return;
        }
        //Build a turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }
}
