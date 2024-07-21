using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnitStack : MonoBehaviour
{
    [SerializeField] private TMP_Text _amountBar;
    private int Amount = 0;

    public void ApplyDamage(int damage)
    {
        Amount -= damage;
        UpdateBar();
        if (Amount < 0)
        {
            Amount = 0;
            Destroy(gameObject);
        }
        
    }

    public void AddAmount (int amount)
    {
        Amount += amount;
        UpdateBar();
    }

    private void UpdateBar()
    {
        _amountBar.text = Amount.ToString();
    }
}
