using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerFIJ : MonoBehaviour
{
    public int nofUnitsToSpawn;
    public List<GameObject> spawnUnit= new List<GameObject>();
    public float spawnTime;
    public Transform EndPosition;
    public List<Transform> route;
    Transform Spawnposition;
    // Start is called before the first frame update
    void Start()
    {
        Spawnposition = transform;
        
        StartCoroutine("spawnUnits");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnUnits()
    {
        for (int cnt = 0; cnt < spawnUnit.Count; cnt++)
        {
            GameObject newEnemy = Instantiate(spawnUnit[cnt], Spawnposition);
            newEnemy.GetComponent<enemyFIJ>().route = route;
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
