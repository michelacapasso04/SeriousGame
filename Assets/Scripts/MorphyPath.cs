using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphyPath : MonoBehaviour
{
    [SerializeField] 
    private Transform[] path;

    private int pathToGo;

    private float tParam;

    private Vector2 MPos;

    private float speedMod;

    private bool corAllowed;
    
    // Start is called before the first frame update
    void Start()
    {
        pathToGo = 0;
        tParam = 0f;
        speedMod = 0.7f;
        corAllowed = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (corAllowed)
        {
            StartCoroutine(GoByThePath(pathToGo));
        }
    }

    private IEnumerator GoByThePath(int pathNum)
    {
        corAllowed = false;

        Vector2 p0 = path[pathNum].GetChild(0).position;
        Vector2 p1 = path[pathNum].GetChild(1).position;
        Vector2 p2 = path[pathNum].GetChild(2).position;
        Vector2 p3 = path[pathNum].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedMod;
            
            MPos = Mathf.Pow(1 - tParam, 3) * p0 +
                   3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 +
                   3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 +
                   Mathf.Pow(tParam, 3) * p3;
            
            transform.position = MPos;
            yield return new WaitForEndOfFrame();
        }

        tParam = 0f;
        pathToGo += 1;
        if (pathToGo > path.Length - 1)
            pathToGo = 0;
        corAllowed = true;
    }
}

//min 8
