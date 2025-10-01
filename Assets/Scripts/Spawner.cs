using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Settings")]
    public float minSpawnDelay;
    public float maxSpawnDelay;
    [Header("References")]
    public GameObject[] gameObjects;

    //오브젝트가 활성화 될때마다 호출되는 메서드
    void OnEnable()
    {
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

    void OnDisable()
    {
        CancelInvoke();
    }
    
    void Spawn()
    {
        GameObject randomObject = gameObjects[Random.Range(0, gameObjects.Length)];
        Instantiate(randomObject, transform.position, Quaternion.identity);
        //함수 불러오기
         Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
