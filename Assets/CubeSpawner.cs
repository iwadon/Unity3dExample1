using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnCube());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnCube()
    {
        while (true)
        {
            var cube = Instantiate<GameObject>(CubePrefab);
            cube.transform.position = new Vector3(Random.Range(-5, 5) + 0.5f, 10, Random.Range(-5, 5) + 0.5f);
            var meshRenderer = cube.GetComponent<MeshRenderer>();
            var material = meshRenderer.material;
            material.color = new Color(Random.value, Random.value, Random.value);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
