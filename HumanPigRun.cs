using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPigRun : MonoBehaviour
{
    private void FixedUpdate() {
        this.transform.rotation *= Quaternion.AngleAxis (-2, Vector3.up);
    }
}
