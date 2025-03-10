using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    //함수정의
    void SayHello()
    {
        Debug.Log("Hello , Unity");
    }

    int AddNumbers(int a, int b)
    {
        return a + b;
    }

    void Start()
    {
        int total = AddNumbers(3, 5);
        Debug.Log($"Total: {total}");

    }


    void Update()
    {

    }
}