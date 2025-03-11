using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    //몬스터 가지고 오기
    public GameObject enemy;

    //적을 생성하는 함수
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);  //적이 나타날 x좌표를 랜덤으로 생성하기

        //적을 생성한다. randomX 랜덤한 x값
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

    }

    void Start()
    {
        //SpawnEnemy    1   0.5f 
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    
    void Update()
    {
        
    }
}
