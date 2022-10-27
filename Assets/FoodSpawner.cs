

using System.Collections;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private GameObject food;
    [SerializeField] private Transform xmin, xmax;
    IEnumerator SpawnFood()
    {
        while (true)
        {
            Instantiate(food, new Vector2(Random.Range(xmin.position.x,xmax.position.x),xmin.position.y), Quaternion.identity);

            yield return new WaitForSeconds(2f);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnFood());
    }
}
