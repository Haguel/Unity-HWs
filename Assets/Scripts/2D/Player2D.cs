using UnityEngine;

namespace _2D
{
    public class Player2D : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            print("Wall!");
            
            if (other.TryGetComponent(out Dirt2D dirt))
            {
                dirt.gameObject.SetActive(false);
            }
        }
    }
}