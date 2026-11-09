using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public Transform foodPrefab;
    public int gridSize = 20; // 20x20 ka 3D grid

    private void Start()
    {
        SpawnFood();
    }

    public void SpawnFood()
    {
        int x = Random.Range(-gridSize / 2, gridSize / 2);
        int z = Random.Range(-gridSize / 2, gridSize / 2);
        Instantiate(foodPrefab, new Vector3(x, 0.5f, z), Quaternion.identity);
    }
}
