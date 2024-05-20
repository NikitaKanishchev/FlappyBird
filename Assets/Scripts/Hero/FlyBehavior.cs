using Services;
using UnityEngine;
using UnityEngine.UI;

namespace Hero
{
    public class FlyBehavior : MonoBehaviour
    {
        [SerializeField] private float _velocity = 1.5f;
        [SerializeField] private float _rotationSpeed = 10f;
        [SerializeField] private AudioClip _audio;
        [SerializeField] private AudioClip _audioDefeat;
        
        public Button jumpButton;

        private Rigidbody2D _rb;


        private void Awake() => 
            jumpButton.gameObject.SetActive(false);

        private void Start()
        {
            jumpButton.gameObject.SetActive(true);
            _rb = GetComponent<Rigidbody2D>();
            jumpButton.onClick.AddListener(Jump);
        }

        private void Jump()
        {
            _rb.velocity = Vector2.up * _velocity;
            AudioSource.PlayClipAtPoint(_audio, transform.position); 
        }
        
        private void FixedUpdate()
        {
            transform.rotation = Quaternion.Euler(0,0, _rb.velocity.y * _rotationSpeed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Pipe")
            {
                FindObjectOfType<GameManager>().GameOver();
                AudioSource.PlayClipAtPoint(_audioDefeat,transform.position);
            }
            
            else if (other.gameObject.tag == "Score")
                FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}
