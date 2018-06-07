using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentController : MonoBehaviour {
  // components
  public Transform headTransform;
  
  // consts
  public float visionRange = 10.0f;
  
  // composition
  public TargetHelper targetHelper;
}
