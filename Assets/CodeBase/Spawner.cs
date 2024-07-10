using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    public GameObject SpawnUnit;
    public float StartDelay;
    public float SpawnTime;
    public void TurnOn()
    {
        InvokeRepeating(nameof(Spawn), StartDelay, SpawnTime);
    }
    public void TurnOff()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        Instantiate(SpawnUnit, _spawnPoint.position, SpawnUnit.transform.rotation);
    }
}
