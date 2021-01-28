using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBonus : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject BonusPrefab;
    public void InstantiateBonus()
    {

        
        GameObject Bonus = Instantiate(BonusPrefab, gameObject.transform);
        Bonus.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        Bonus.transform.SetParent(null);



    }
   
}
