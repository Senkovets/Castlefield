using UnityEngine;

public class BuildingVisualBehaviour : MonoBehaviour
{
    public void BarrackProduce()
    {
        ShowUnit();
    }
    private void ShowUnit()
    {
        Debug.Log("ViewUnit");
    }

    public void EconomicsProduce()
    {
        ShowCoin();
    }
    private void ShowCoin()
    {
        Debug.Log("ViewCoin");
    }
}
