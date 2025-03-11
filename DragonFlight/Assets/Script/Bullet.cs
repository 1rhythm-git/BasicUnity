using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject exposion;

    
    /*void Start()
    {
        Singleton.Instance.PrintMessage();
    }*/

    
    void Update()
    {
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //미사일이 화면 밖으로 나갔으면
        //미사일 삭제
        Destroy(gameObject);

        //GameObject(대문자는 클래스), gameObject(소문자는 자기자신)

    }

    //2D 충돌 트리거 이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 충돌
        //if(collision.gameObject.tag == "Enemy")
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //폭발 이펙트 생성
            Instantiate(exposion, transform.position, Quaternion.identity);
            //사망사운드
            SoundManager.instance.SoundDie();   //적 사망 사운드
            //점수올려주기
            GameManager.instance.AddScore(10);

            //적 지우기
            Destroy(collision.gameObject);
            //총알 지우기 자기자신
            Destroy(gameObject);

        }
    }



}
