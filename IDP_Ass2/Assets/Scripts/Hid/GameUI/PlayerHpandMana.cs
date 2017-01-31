using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHpandMana : MonoBehaviour {

    private float Health, MaxHealth;
    private bool CanHit;
    public GameObject HealthBar;
    private float timer, MaxTimer;
    public GameObject Shop, Enemy;
    float Dist;

	// Use this for initialization
	void Start () 
    {
        CanHit = true;
        timer = 0.0f;
        MaxTimer = 2.0f;
        Health = 100;
        MaxHealth = Health;
        Dist = 1.8f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        CheckingCollision();
        UpdateHealth();
   	}

    void ShopRender()
    {
        SceneManager.LoadScene("Dialogue");
    }

    public void ShopCheck()
    {
        if (Vector3.Distance(transform.position, Shop.transform.localPosition) < Dist)
        {
            ShopRender();
        }
    }

    void UpdateHealth()
    {
        float scale = (Health / MaxHealth);
        HealthBar.transform.localScale = new Vector3(scale, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
    }

    void CheckingCollision()
    {
        if (!CanHit)
        {
            timer += Time.deltaTime;
            if (timer > MaxTimer)
            {
                timer = 0.0f;
                CanHit = true;
            }
        }
        if (Vector3.Distance(transform.position, Enemy.transform.localPosition) < Dist)
        {
            if (CanHit)
            {
                Handheld.Vibrate();
                Health -= 10;
                CanHit = false;
            }
        }
    }
}
