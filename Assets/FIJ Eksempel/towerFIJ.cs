using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerFIJ : MonoBehaviour
{
    protected List<GameObject> enemies = new List<GameObject> ();
    public GameObject head;
    public GameObject bullet;
    public GameObject firingPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("fire"); 
    }


    IEnumerator fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (enemies.Count > 0)
            {
                head.transform.LookAt(selectEnemy().transform);  
                GameObject bulletObj=Instantiate(bullet,null);
                bulletObj.transform.position=firingPoint.transform.position;
                bulletObj.GetComponent<bulletFIJ>().target = selectEnemy();
                bulletObj.GetComponent<bulletFIJ>().tower = gameObject; 
            }
        }
    }

    public virtual GameObject selectEnemy()
    {
        return enemies[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="enemy")
        {
            enemies.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            enemies.Remove(other.gameObject);
        }
    }

    public void removeEnemy(GameObject obj)
    {
        enemies.Remove(obj);
    }
}
