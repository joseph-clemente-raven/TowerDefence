using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turrent;

    private Renderer rend;
    private Color startColor;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown ()
    {
        if (turrent != null)
        {
            Debug.Log("Can't build");
            return;
        }

        GameObject turrentToBuild = BuildManager.instance.GetTurrentToBuild();
        turrent = (GameObject)Instantiate(turrentToBuild, transform.position + positionOffset, transform.rotation);

    }

    void OnMouseEnter ()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }
}
