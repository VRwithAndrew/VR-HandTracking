using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material pinkMaterial = null;
    public Material tealMaterial = null;

    private MeshRenderer meshRenderer = null;

    public void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetPink(CustomHand customHand)
    {
        meshRenderer.material = pinkMaterial;
    }

    public void SetTeal(CustomHand customHand)
    {
        meshRenderer.material = tealMaterial;
    }
}
