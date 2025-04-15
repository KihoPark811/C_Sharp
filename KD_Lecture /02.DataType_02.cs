// KD C# Programming Lecture(Data Type)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    
    int a = 100; // 자료형 long 과 int 간의 계산은 오류가 없다.(long ⊃ int)
    float b = 100.15f;

    float sum2;
    int sum;
  
    // Use this for initialization
    void Start () {
        sum = (int)(a + b); // cast: 자료형 강제 변환 → 이런 방식으로 계산 오류를 해결할 수 있다.
        sum2 = a + b;

        print(sum2);
        print(sum);
    }

    // Update is called once per frame
    void Update () {

    }
}
