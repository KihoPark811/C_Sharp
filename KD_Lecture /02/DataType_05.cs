using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
  int a;
  string b = "100";

  // 자료형 학습
  ushort au = -500;
  // short (-3만 ~ +3만), ushort (0~+6)

  // Use this for initialization
  void Start() {
    // 문자열을 정수로 변환하는 방법(강제형 변환 간 포맷 불일치 문제가 발생할 수 있다.)
    a = int.Parse(b); // short.Parse(), double.Parse() 등 가능하다.
    print(a);
  }

  // Update is called once per frame
  void Update () {

  }
