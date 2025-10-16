using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2
{
    private int a;
    public int b;
    public static int c; // 공공의 공유자원, 정적 변수
}

public class Test : MonoBehaviour {

   Test2 a1 = new Test2();
   Test2 a2 = new Test2();
   Test2 a3 = new Test2();

   void Start()
   {
      Abc();
   }

  // 지역 변수의 우선순위가 멤버 변수보다 높기 때문에 지역 변수가 적용된다.
   void Abc()
   {
      a1.b = 1;
      a2.b = 5;
      a3.b = 10;

     // 클래스 자체로 접근할 수 있기 때문에 쉽게 수정, 참조 등이 가능하다.
      Test2.c = 100;

      print(a1.b);
      print(a2.b);
      print(a3.b);
  }

}
