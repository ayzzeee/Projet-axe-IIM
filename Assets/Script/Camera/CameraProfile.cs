using UnityEngine;

public class CameraProfile : MonoBehaviour
{

    [Header("Type")]
    [SerializeField] private CameraProfileType _profileType = CameraProfileType.Static;

    [Header("Follow")]
    [SerializeField] private CameraFollowable _targetToFollow = null;

    [Header("Offset")]
    [SerializeField] private CameraFollowOffset _followOffset;
    [SerializeField] private bool _useFollowOffset = false;

    [Header("Autoscroll")]
    [SerializeField] private CameraAutoScroll _autoScroll;

    public CameraAutoScroll CameraAutoScroll => _autoScroll;


    public CameraFollowable TargetToFollow => _targetToFollow;
    public CameraProfileType ProfileType => _profileType;

    [Header("Damping")]
    [SerializeField] private bool _useDampingHorizontally = false;
    [SerializeField] private bool _useDampingVertically = false;
    [SerializeField] private float _horizontalDampingFactor = 5f;
    [SerializeField] private float _verticalDampingFactor = 5f;




    public bool UseFollowOffset => _useFollowOffset;
    public CameraFollowOffset FollowOffset => _followOffset;



    [Header("Bounds")]
    [SerializeField] private bool _hasBounds = false;
    [SerializeField] private Rect _boundsRect = new Rect(0f, 0f, 10f, 10f);
    public bool HasBounds => _hasBounds;
    public Rect BoundsRect => _boundsRect;

    public bool UseDampingHorizontally => _useDampingHorizontally;
    public bool UseDampingVertically => _useDampingVertically;

    public float HorizontalDampingFactor => _horizontalDampingFactor;

    public float VerticalDampingFactor => _verticalDampingFactor;

    private Camera _camera;
    public float CameraSize => _camera.orthographicSize;
    public Vector3 Position => _camera.transform.position;
    public enum CameraProfileType
    {
        Static = 0,
        FollowTarget,
        AutoScroll
    }

    private void Awake()
    {
        _camera = GetComponent<Camera>();
        if (_camera != null)
        {
            _camera.enabled = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (!_hasBounds) return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(_boundsRect.center, _boundsRect.size);
    }
}
