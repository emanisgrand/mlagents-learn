using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodButton : MonoBehaviour
{
    public event EventHandler OnUsed;
    
    [SerializeField] Material greenMaterial;
    [SerializeField] Material greenDarkMaterial;
    [SerializeField] Transform buttonTransform; // being used to access the mesh renderer.
    [SerializeField] Transform buttonBase;
     
    private MeshRenderer buttonMeshRenderer;
    private bool canUseButton;
    public bool CanUseButton()
    {
        return canUseButton;
    }

    private void Awake()
    {
        buttonTransform = gameObject.transform;
        buttonMeshRenderer = buttonTransform.GetComponent<MeshRenderer>();
        canUseButton = true;
    }

    public void UseButton()
    {
        if (canUseButton)
        {
            buttonMeshRenderer.material = greenDarkMaterial;
            buttonTransform.localScale = new Vector3(.5f, .2f, .5f);
            canUseButton = false;

            OnUsed?.Invoke(this, EventArgs.Empty);
        }
    }

    

    public void ResetButton()  
    {
        buttonMeshRenderer.material = greenMaterial;
        transform.localScale = new Vector3(.5f, .5f, .5f);
        buttonBase.localPosition =
            new Vector3(
                UnityEngine.Random.Range(-3f, 4f), buttonBase.localPosition.y, UnityEngine.Random.Range(-5.2f, 3.7f));

        canUseButton = true;
    }
}
