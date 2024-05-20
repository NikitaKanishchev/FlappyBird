using Hero;
using UnityEngine;

namespace PipeLogic
{
    public class TouchPipe : MonoBehaviour
    {
        
        [SerializeField] private Collider2D _collider2D;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out FlyBehavior flyBehavior)) ;
        }
    }
}
