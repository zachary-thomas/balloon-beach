using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public int moveLevel = 200;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Transfer");
    }

    IEnumerator Transfer()
    {
        Debug.Log("Hit the trigger zone");
        yield return new WaitForSeconds(1);
        Debug.Log("Hit the trigger zone after one second");

        gameObject.transform.parent.position = new Vector3(0, -0.5f, gameObject.transform.position.z + moveLevel);
    }
}
