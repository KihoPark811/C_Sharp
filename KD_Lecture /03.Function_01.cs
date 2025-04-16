using System.Collection;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
  int intValue;

  void FloatToInt()
  {
    intValue = (int)floatValue;
  }

  // Use this for initialization
  void Start () {
    FloatToInt();
    FloatToInt();
    print(intValue);
  }

  // Update is called once per frame
  void Update () {

  }
  
