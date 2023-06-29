using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject objectPrefab; // 생성할 오브젝트의 프리팹
    public GameObject objectPrefab2; // 생성할 오브젝트의 프리팹
    public GameObject objectPrefab3; // 생성할 오브젝트의 프리팹
    public GameObject objectPrefab4; // 생성할 오브젝트의 프리팹
    

    public int numberOfObjects = 15; // 생성할 오브젝트의 수
    public Vector3 spawnArea = new Vector3(10f, 0f, 10f); // 생성할 영역의 크기
    public float spacing = 75f; // 오브젝트들 사이의 간격
    public float heightOffset = 100f; // 오브젝트의 높이 오프셋
    public float heightOffset2 = 150f; // 오브젝트의 높이 오프셋
    public float heightOffset3 = -30f; // 오브젝트의 높이 오프셋
    public float heightOffset4 = 300f; // 오브젝트의 높이 오프셋
    



    private void Start()
    {
        GenerateObjects();
        GenerateObjects2();
        GenerateObjects3();
        GenerateObjects4();
        
    }

    private void GenerateObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomPosition = transform.position + new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2) + (i * spacing),
                heightOffset,
                Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
            );

            GameObject newObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);
            newObject.transform.SetParent(transform);
        }
    }
    private void GenerateObjects2()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomPosition = transform.position + new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2) + (i * spacing),
                heightOffset2,
                Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
            );

            GameObject newObject = Instantiate(objectPrefab2, randomPosition, Quaternion.identity);
            newObject.transform.SetParent(transform);
        }
    }
    private void GenerateObjects3()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomPosition = transform.position + new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2) + (i * spacing),
                heightOffset3,
                Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
            );

            GameObject newObject = Instantiate(objectPrefab3, randomPosition, Quaternion.identity);
            newObject.transform.SetParent(transform);
        }
    }
    private void GenerateObjects4()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomPosition = transform.position + new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2) + (i * spacing),
                heightOffset4,
                Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
            );

            GameObject newObject = Instantiate(objectPrefab4, randomPosition, Quaternion.identity);
            newObject.transform.SetParent(transform);
        }
    }
   
    
}