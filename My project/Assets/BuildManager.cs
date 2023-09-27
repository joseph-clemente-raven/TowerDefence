using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake ()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurrentPrefab;

    void Start ()
    {   
        turrentToBuild = standardTurrentPrefab;
    }
    
    private GameObject turrentToBuild;

    public GameObject GetTurrentToBuild ()
    {
        return turrentToBuild;
    }
}
