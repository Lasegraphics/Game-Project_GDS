using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateBonus : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject BonusPrefab;
    
  
  
   public void InstanciateIt()
    {


        GameObject Bonus = Instantiate(BonusPrefab, gameObject.transform);
        Bonus.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        Bonus.transform.SetParent(null);
        //Destroy(Bonus,2f);
        //Destroy(this.gameObject); 
    
    }
}
