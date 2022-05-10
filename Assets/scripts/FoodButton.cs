using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodButton : MonoBehaviour
{
    bool canUseButton;
    [SerializeField] Transform buttonTransform;
    [SerializeField] MeshRenderer buttonMeshRenderer;
    [SerializeField] Material greenMaterial;
    [SerializeField] Material greenDarkMaterial;

    

    public void UseButton()
    {
        if (canUseButton)
        {
            buttonMeshRenderer.material = greenDarkMaterial;
            buttonTransform.localScale = new Vector3(.5f, .2f, .5f);
            canUseButton = false;
        }
    }

    public void ResetButton()
    {
        buttonMeshRenderer.material = greenMaterial;
        buttonTransform.localScale = new Vector3(.5f, .5f, .5f);

        transform.localPosition =
            new Vector3(
                transform.localPosition.x, transform.localPosition.y, UnityEngine.Random.Range(-3, 4));

        canUseButton = true;
    }
}
