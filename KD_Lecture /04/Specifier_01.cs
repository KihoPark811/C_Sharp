using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    int a = 5; // 멤버 변수, 전역 변수

    void Abc()
    {
        int a = 5; // 지역 변수
        a = 6; // 지역 변수의 우선순위가 멤버 변수보다 높기 때문에 지역 변수가 적용된다.

        int b = 5; // 지역 변수
        print(b);
    }

    void Abc2()
    {
        int b = 5;
        print(b);

    void Abc3(float _parameter) // 파라미터
    {
      
    }
}
