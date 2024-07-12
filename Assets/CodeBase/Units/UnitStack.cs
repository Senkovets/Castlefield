using UnityEngine;

public class UnitStack : MonoBehaviour
{
    private int Amount = 0;

    public void ApplyDamage(int damage)
    {
        Amount -= damage;
        if (Amount < 0)
        {
            Amount = 0;
            Destroy(gameObject);
        }
        
    }

    public void AddAmount (int amount)
    {
        Amount += amount;
    }
}
