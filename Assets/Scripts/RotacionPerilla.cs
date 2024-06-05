using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotacionPerilla : MonoBehaviour
{
    private Camera _camera;
    private Vector3 _position;
    private float angleOffset;
    private Collider2D _collider;

    private void Start()
    {
        _camera = Camera.main;
        _collider = GetComponent<Collider2D>();
    }
    private void Update()
    {
        Vector3 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (_collider == Physics2D.OverlapPoint(mousePosition))
            {
                _position = _camera.ScreenToWorldPoint(transform.position);
                Vector3 vec3 = Input.mousePosition - _position;
                angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y,vec3.x)) * Mathf.Rad2Deg;
            }

        }
        if (Input.GetMouseButton(0))
        {
            if (_collider == Physics2D.OverlapPoint(mousePosition))
            {
                
                Vector3 vec3 = Input.mousePosition - _position;
                float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0,0,angle + angleOffset);
            }

        }
    }
}
