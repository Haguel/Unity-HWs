using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Bullet bulletInstance = Instantiate(_bulletPrefab, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}