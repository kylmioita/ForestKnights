using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;
    public float MaxHealth = 100;

    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / MaxHealth;
    }

    private void Update()
    {

        this.gameObject.SetActive(!Health.dead);
        if (Health.dead)
        {
            return;
        }

        currenthealthBar.fillAmount = playerHealth.currentHealth / MaxHealth;
    }
}
