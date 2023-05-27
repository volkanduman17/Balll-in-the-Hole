using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMaterialController : MonoBehaviour
{
    [SerializeField] private List<Material> mats;

    private MeshRenderer ballRenderer;

    private void Awake()
    {
        ballRenderer = GetComponent<MeshRenderer>();

        ballRenderer.material = mats[DataManager.MaterialID];
    }
}
