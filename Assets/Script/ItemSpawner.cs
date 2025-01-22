using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public List<Transform> Position;
    public GameObject gasPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGas());
    }

    IEnumerator SpawnGas()
    {
        while (true)
        {
            // 랜덤 주기 설정
            float randomInterval = Random.Range(2, 6);

            // 랜덤 시간 대기
            yield return new WaitForSeconds(randomInterval);

            // 실행할 동작
            Instantiate(gasPrefab, Position[Random.Range(0, 3)].position, Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
