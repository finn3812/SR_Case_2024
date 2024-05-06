using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndPointFIJ : MonoBehaviour
{
    public float healtPoint = 100;
    TMP_Text healtText;
    // Start is called before the first frame update
    void Start()
    {
        healtText = GameObject.Find("Life").GetComponent<TMP_Text>(); 
        healtText.text = "Life: " + healtPoint.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="enemy")
        {
            healtPoint -= 30;
            healtText.text="Life: "+healtPoint.ToString();
            Destroy(other.gameObject);
            Debug.Log("Enemy succes");
            if(healtPoint <= 0)
            {
                Debug.Log("Game over");
            }
        }
    }
}
