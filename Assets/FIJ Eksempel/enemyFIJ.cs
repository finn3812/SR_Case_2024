using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyFIJ : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    public Transform endpoint;
    healthBarFIJ HBar;
    public List<Transform> route=new List<Transform>();
    int routeCnt = 0;
    public float HP = 50;
    void Start()
    {
        HBar=gameObject.GetComponentInChildren<healthBarFIJ>();
        HBar.SetupRange(HP);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(route[routeCnt].position);
        if(agent.remainingDistance<1)
        {
            if (routeCnt < route.Count - 1)
            {
                routeCnt++;
            }
        }
    }

    public void damage(float damageAmount, GameObject towerObj)
    {
        HP -= damageAmount;
        HBar.SetHealtBar(HP);
        if (HP <= 0)
        {
            towerObj.GetComponent<towerFIJ>().removeEnemy(gameObject);
            Destroy(gameObject);
        }
    }
}
