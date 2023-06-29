using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject objectPrefab; // ������ ������Ʈ�� ������
    public GameObject objectPrefab2; // ������ ������Ʈ�� ������
    public GameObject objectPrefab3; // ������ ������Ʈ�� ������
    public GameObject objectPrefab4; // ������ ������Ʈ�� ������
    

    public int numberOfObjects = 15; // ������ ������Ʈ�� ��
    public Vector3 spawnArea = new Vector3(10f, 0f, 10f); // ������ ������ ũ��
    public float spacing = 75f; // ������Ʈ�� ������ ����
    public float heightOffset2 = 150f; // ������Ʈ�� ���� ������
    public float heightOffset3 = -30f; // ������Ʈ�� ���� ������
    public float heightOffset4 = 300f; // ������Ʈ�� ���� ������
    



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