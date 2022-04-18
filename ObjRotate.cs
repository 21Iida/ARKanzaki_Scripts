using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotate : MonoBehaviour
{
    private void FixedUpdate() {
        this.transform.rotation *= Quaternion.AngleAxis (0.1f, Vector3.forward);
    }
}
