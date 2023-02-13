using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BricksControl : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms = 10;
    public float xMin = -5f;
    public float xMax = 5f;
    public float yMin = 2f;
    public float yMax = 6f;
    public float overlapCheckRadius = 0.5f;
    public LayerMask platformLayer;

    private void Start()
    {
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            Vector3 platformPosition = GetRandomPosition();

            while (Physics2D.OverlapCircle(platformPosition, overlapCheckRadius, platformLayer))
            {
                platformPosition = GetRandomPosition();
            }

            Instantiate(platformPrefab, platformPosition, Quaternion.identity);
        }
    }

    private Vector3 GetRandomPosition()
    {
        float xPosition = Random.Range(xMin, xMax);
        float yPosition = Random.Range(yMin, yMax);
        float zPosition = 0f;

        return new Vector3(xPosition, yPosition, zPosition);
    }
}
