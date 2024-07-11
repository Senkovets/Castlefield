using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    private bool _isSpawning;
    public GameObject UnitPrefab;
    public float SpawnTime;
    private void Start()
    {
        On();
    }
    public void On()
    {
        _isSpawning = true;
        StartCoroutine(Spawn());
    }
    public void Off()
    {
        _isSpawning = false;
        StopCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (_isSpawning)
        {
            yield return new WaitForSeconds(SpawnTime);
            Instantiate(UnitPrefab, _spawnPoint.position, UnitPrefab.transform.rotation);
        }
    }
}
