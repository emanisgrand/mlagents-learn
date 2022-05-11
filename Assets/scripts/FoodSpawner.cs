using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public bool HasSpawnedFood { get; private set; }

    [SerializeField] Transform foodSpawnPos;
    [SerializeField] GameObject food;

    [SerializeField] FoodButton buttonRef;

    private Transform targetTransform;

    private void Start()
    {
        buttonRef.OnUsed += SpawnFood;
    }

    public void SpawnFood(object sender, EventArgs e) // signature must match.
    {
        GameObject.Instantiate(food, foodSpawnPos);
        targetTransform = food.transform;
        HasSpawnedFood = true;        
    }

    public Transform GetLastTargetPosition()
    {
        return targetTransform;    
    }
}
