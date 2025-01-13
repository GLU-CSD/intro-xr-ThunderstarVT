using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public string prefabTag = "Enemy";
    private Enemy enemyScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript == null)
        {
            GameObject spawnedPrefab = GameObject.FindWithTag(prefabTag);
            if (spawnedPrefab != null)
            {
                enemyScript = spawnedPrefab.GetComponent<Enemy>();
            }
        }
    }

    public void DamageButton()
    {
        if (enemyScript != null)
        {
            enemyScript.TakeDamage(1); 
        }
    }

    public void HealButton()
    {
        if (enemyScript != null)
        {
            enemyScript.RestoreHealth(1); 
        }
    }
}
