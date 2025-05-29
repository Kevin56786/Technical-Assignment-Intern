using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _movingSpeed = 5f;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private VectorValue _positionPlayer;

    private Rigidbody2D _rb;

    public Vector2 InputVector;

    public static Player Instance { get; set; }

    private void Awake()
    {
        Instance = this;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.position = _positionPlayer.InitialValue;
    }
    
    private void Update()
    {
        InputVector= new Vector2(_joystick.Horizontal, _joystick.Vertical);
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (InputVector.magnitude > 0.1f)
        {
            InputVector = InputVector.normalized;
            _rb.MovePosition(_rb.position + InputVector * (_movingSpeed * Time.fixedDeltaTime));
        }
        
    }
}
