using UnityEngine;

namespace _2D
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMover2D : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _speed;
        [SerializeField] private float _torqueForce;

        private void Update()
        {
            Move();
            Rotate();
        }

        private void Rotate()
        {
            var horizontalInput = Input.GetAxis("Horizontal");
    	    var rotationVector = new Vector3(0f, 0f, horizontalInput) * (_speed * Time.deltaTime);
            
            transform.Rotate(rotationVector);
        }

        private void Move()
        {
            var verticalInput = Input.GetAxis("Vertical");
            var movementVector = new Vector2(verticalInput, 0) * (_speed * Time.deltaTime);
            
            _rigidbody.velocity = transform.TransformDirection(movementVector);
        }
    }
}
