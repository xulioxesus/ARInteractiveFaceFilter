using System;
using UnityEngine;

public class MeshController : MonoBehaviour
{
    public String[] meshTags;

    private String lastMeshTag;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisableAllMeshes();
    }

    public void EnableMeshByTag(string tag)
    {
        GameObject meshObject = GameObject.FindWithTag(tag);
        if (meshObject != null)
        {
            DisableAllMeshes();
            meshObject.GetComponent<Renderer>().enabled = true;
            lastMeshTag = tag;
        }
    }

    private void DisableAllMeshes()
    {
        foreach (string tag in meshTags)
        {
            GameObject meshObject = GameObject.FindWithTag(tag);
            if (meshObject != null)
            {
                meshObject.GetComponent<Renderer>().enabled = false;
                //meshObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        GameObject meshObject = GameObject.FindWithTag(lastMeshTag);
        if (meshObject != null)        {
            meshObject.GetComponent<Renderer>().enabled = true;
        }
    }
}