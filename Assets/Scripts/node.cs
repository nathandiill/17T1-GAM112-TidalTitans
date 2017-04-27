
using UnityEngine;

public class node : MonoBehaviour {

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    private Vector3 turretposition;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        turretposition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
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
        turret = (GameObject)Instantiate(turretToBuild, turretposition, transform.rotation);
    }
}
