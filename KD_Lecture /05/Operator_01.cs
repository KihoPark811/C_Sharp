using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
   // 기본 연산자 : +, -, *, /, %, =(대입연산자)
   // 증감 연산자 : ++, --
   // 연산자 전위 : [선 연산 후 코드 실행]
   // 연산자 후위 : [선 코드 실행 후 연산]
   // 관계 연산자 : ==, <=, >=, >, <, !=
   // 논리 연산자 : &&, ||, !
   // 비트 연산자 : &(AND), |(OR), ^(XOR), ~(NOT)
   // 
   int a = 10;
   int b = 3;
   int c = 0;
   bool d = false;

   void Start() {
      a %= b; // 복합 대입 연산자
      c = c + 1; // c += 1; 또는 c++ 또는 ++c
      c = c - 1; // c -= 1; 또는 c-- 또는 --c

      d = (a != b) && (a == b); // 관계 연산자 : !=, == , 논리 연산자  : && (And - 모든 조건이 참일 경우에만 True), || (OR - 조건 중에 하나라도 참이 있을 경우에는 True)  
      print(d);
   }
}
