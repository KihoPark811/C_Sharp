using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test :: MonoBehaviour {
    int num = 0;

    void Start() {
        for(int i = 0; i < 10; i++) // for문은 반복 횟수가 명확할 때 사용하는 것이 좋다.
        {
            // 이중 for문 가능
            // if 문 가능
            // ...
        }

        // while문은 반복 횟수가 명확하지 않을 때 사용하는 것이 좋다.
        while(true) // 무한 루프: 특정 구간을 무한히 반복하는 오류로, 무한 루프에 빠지면 프로그램이 멈춘다.
        {
            if(num < 10)
                num++;
                break;
            print(num);
        }

        do // 한 번은 무조건 실행되는 반복문이다.
        {
            num++;
            print(num);
        } while(num < 10);


        string text = "가나다라마바사";
        foreach(char a in text) // 커다란 덩어리를 작은 알맹이로 쪼개서 그 알맹이의 갯수만큼 반복하는 것이 가능한 반복분이다.
        {
            print(a);
        }
    }

    }
