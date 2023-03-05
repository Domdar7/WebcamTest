using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private BoxCollider2D thisOneLmao;

    private void Start()
    {
        
        thisOneLmao = GetComponent<BoxCollider2D>();
        StartCoroutine(spawnMe());
    }
    IEnumerator spawnMe()
    {
        yield return new WaitForSeconds(2);
        this.transform.position = new Vector3(0, 0, 0);
        thisOneLmao.enabled = true;
    }
}
