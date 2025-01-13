using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public int temporaryHealth;
    public Image healthbarFill;

    public int STR;
    public int DEX;
    public int CON;
    public int WIS;
    public int INT;
    public int CHA;

    // Start is called before the first frame update
    void Start()
    {
        STR = GenStat();
        DEX = GenStat();
        CON = GenStat();
        WIS = GenStat();
        INT = GenStat();
        CHA = GenStat();



        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > maxHealth) { currentHealth = maxHealth; }
        if (currentHealth < 0) { currentHealth = 0; }
        if (temporaryHealth < 0) { currentHealth += temporaryHealth;  temporaryHealth = 0; }

        healthbarFill.transform.localScale = new Vector3((float) (currentHealth + temporaryHealth) / maxHealth, 1, 1);
    }


    public void TakeDamage(int amount)
    {
        temporaryHealth -= amount;
    }

    public void RestoreHealth(int amount)
    {
        currentHealth += amount;
    }

    public void AddTempHealth(int amount)
    {
        temporaryHealth += amount;
    }


    private int GenStat()
    {
        int d1 = Random.Range(1, 7);
        int d2 = Random.Range(1, 7);
        int d3 = Random.Range(1, 7);
        int d4 = Random.Range(1, 7);

        return d1 + d2 + d3 + d4 - Mathf.Min(d1, d2, d3, d4);
    }
}
