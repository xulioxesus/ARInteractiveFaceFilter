using System;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public String[] meshTags;
    public Material[] materials;

    private int lastMaterial = -1;

    public void ChangeAllMaterials(int index)
    {
        lastMaterial = index;
        foreach (string tag in meshTags)
        {
            GameObject gameobject = GameObject.FindWithTag(tag);
            if (gameobject != null)
            {
                gameobject.GetComponent<Renderer>().material = materials[index];
            }
        }
    }

    void Update()
    {
        if (lastMaterial != -1)
        {
            foreach (string tag in meshTags)
            {
                GameObject gameobject = GameObject.FindWithTag(tag);
                if (gameobject != null)
                {
                    gameobject.GetComponent<Renderer>().material = materials[lastMaterial];
                }
            }
        }
    }
}