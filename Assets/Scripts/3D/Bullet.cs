using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}