using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TargetHelper : MonoBehaviour {

  GameObject[] getTargetsInRange(Transform root, float distance) {
    GameObject[] targets = GameObject.FindGameObjectsWithTag("Player");
    return targets.Where(target => (target.transform.position - root.position).magnitude < distance).ToArray(); 
  }
}
