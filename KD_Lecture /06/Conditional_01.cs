using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    int input = 5;
    int num = 10;

    bool result;

    void Start() {
        result = input > num;

        if(result)
        {
            print("input의 값이 num보다 큽니다.");
        }
        else
        {
            print("input의 값이 num보다 작습니다.");
        }
    }
