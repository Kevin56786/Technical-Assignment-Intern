using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerVisual : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private bool _isFacingRightLeft = true;
    private bool _isFacingUpDown = false;

    [SerializeField] private float _rotationSmoothing = 5f;
    [SerializeField] private float _verticalThreshold = 0.5f; 

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        AdjustPlayerFacingDirection();
    }

    private void AdjustPlayerFacingDirection()
    {
        Vector3 moveDirection = Player.Instance.InputVector;

        if (moveDirection.magnitude < 0.1f)
            return;

        bool isMovingVertically = Mathf.Abs(moveDirection.y) > _verticalThreshold && Mathf.Abs(moveDirection.y) > Mathf.Abs(moveDirection.x);

        if (isMovingVertically)
        {
            // Вертикальное движение
            bool shouldFaceUpDown = moveDirection.y > 0;

            if (shouldFaceUpDown != _isFacingUpDown)
            {
                FlipVertical();
            }
        }
        else
        {
            // Горизонтальное движение 
            bool shouldFaceRightLeft = moveDirection.x > 0;

            if (shouldFaceRightLeft != _isFacingRightLeft)
            {
                FlipHorizontal();
            }
        }
    }

    private void FlipHorizontal()
    {
        _isFacingRightLeft = !_isFacingRightLeft;
        _spriteRenderer.flipX = !_isFacingRightLeft;
    }

    private void FlipVertical()
    {
        _isFacingUpDown = !_isFacingUpDown;
        _spriteRenderer.flipY = !_isFacingUpDown;
    }
}
