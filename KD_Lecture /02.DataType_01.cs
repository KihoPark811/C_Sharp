// KD C# Programming Lecture(Data Type)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    long a = 4000000000;

    // byte: 정수 자료형(0 ~ 255) - 1 Byte
    // sbyte: 정수 자료형(-128 ~ 127) - 1 Byte
    // short: 정수 자료형(-30000 ~ +30000) - 2 Byte
    // integer: 정수 자료형(-20억 ~ +20억) - 4 Byte
    // long: 정수 자료형 - 8 Byte

   float f = 4.000001f;
   double d = 4.000001; // double은 f를 안 붙여도 된다.
   decimal m = 4.0000001m; // m을 붙여야 오류가 사라진다.

    // float: 실수 자료형(컴퓨터 계산 간 무조건 오차가 생김)
    // double: 실수 자료형(float보다 오차 범위가 적다)
    // decimal: 실수 자료형(오차 범위가 거의 없다.)

   // 문자 자료형
    string s = "Kiho_Park"; // 문자열 자료형
    char c = 'A'; // (시스템 내부에서 유니코드로 저장된다.) 문자 1만 저장 가능하다. // 문자 자료형(유니코드 저장)
  
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
