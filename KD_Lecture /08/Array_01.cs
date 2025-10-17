using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    int[] exp = {50, 100, 150, 200, 250, 300};

    void Start(){
        exp[5] = 500;
        print(exp[5]);

        exp[6] = 1000;

        for(int i = 0; i < exp.Length; i++)
        {
            print(exp[i]);
        }
    }
}
