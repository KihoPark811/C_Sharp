using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    int input = 5;
    int num = 10;
    string input2 = "가나다";

    bool result;

    void Start() {

      /* 
      [if ~ else if ~ else 문]
        if(input == num)
        {
            print("input의 값이 num과 같습니다.");
        }
      
        else if(input > num)
        {
            print("input의 값이 num보다 큽니다.");
        }
      
        else if(input < num)
        {
            print("input의 값이 num보다 작습니다.");
        }
        else
        {
            print("그 밖의 경우");
        }
      */

      /*
      [switch 문]
        switch (input)
        {
          case 10:
              print("input의 값이 10입니다.");
              break;
          case 11:
              print("input의 값이 11입니다.");
              break;
          case 12:
              print("input의 값이 12입니다.")
              break;
          case: "가":
              print("input의 값이 '가'입니다.")
              break;
          case: "나":
              print("input의 값이 '가'입니다.")
              break;
          case: "가나":
              print("input의 값이 '가'입니다.")
              break;
          default:
              print("그 외의 경우");
              break;
        }
        */

        int temp = (input == num) ? 50 : 100; // 삼항 연산자
      
    }
