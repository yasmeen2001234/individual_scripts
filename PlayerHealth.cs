using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{

    public float playerHealth;
    public Image healthImpact;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "DamageZone")
        {
            PlayerTakingDamage(0.5f);
        }

        if (other.gameObject.name == "SafeZone")
        {
            PlayerNotTakingDamage(0.5f);
        }
    }

    void HealthDamageImpact()
    {
        float transparency = 1f - (playerHealth / 100f);
        Color imageColor = Color.white;
        imageColor.a = transparency;
        healthImpact.color = imageColor;
    }

    void PlayerTakingDamage(float damage)
    {
        if(playerHealth > 0)
        {
            playerHealth -= damage;
            Debug.Log("player is taking damage");
        }
    }

    void PlayerNotTakingDamage(float health)
    {
        if (playerHealth < 100)
        {
            playerHealth += health;
            Debug.Log("player is not taking damage");
        }
    }



    //Update is called once per frame 
    void Update()
    {
        HealthDamageImpact();
    }

}
