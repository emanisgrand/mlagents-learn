using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public bool HasSpawnedFood { get; set; }

    [SerializeField] Transform foodSpawnPos;
    [SerializeField] GameObject food;
    [SerializeField] FoodButton buttonRef;
    [SerializeField] MoveToGoalAgent agentRef;

    private Transform targetTransform;

    private void Start()
    {
        buttonRef.OnUsed += SpawnFood;
        agentRef.OnEpisodeBeginEvent += ResetFood;
    }

    public void SpawnFood(object sender, EventArgs e) // signature must match.
    {
        if (!HasSpawnedFood)
        {
            GameObject.Instantiate(food, foodSpawnPos);
            targetTransform = food.transform;
            HasSpawnedFood = true;
        }
    }


    public void ResetFood(object sender, EventArgs e)
    {
        if (HasSpawnedFood)
        {
            Destroy(food);
        }
    }

    public Transform GetLastTargetPosition()
    {
        return targetTransform;    
    }
}
