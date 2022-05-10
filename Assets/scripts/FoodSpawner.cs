using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    private bool hasSpawnedFood;
    Transform foodTransform;

    public bool HasSpanwedFood()
    {
        return hasSpawnedFood;
    }

    public Transform GetLastFoodTransform()
    {
        return foodTransform;
        
    }
}
