using UnityEngine;

public class Dirt : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    private void Update()
    {
        transform.Rotate(0f, _rotationSpeed * Time.deltaTime, 0f);
    }
}