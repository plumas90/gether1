using System.Collections;
using System.Collections.Generic;
using Unity.XR.Oculus.Input;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class TopDownControl : TopDownMove
{
    public SpriteRenderer sprite;
    
    private TopDownMove _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _controller = GetComponent<TopDownMove>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }
    private void FixedUpdate() // 물리처리후 호출됨 = 업데이트보다 호출이 느림
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5f;
        _rigidbody2D.velocity = direction; //속도 저장
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
       Debug.Log("움직이는중");
    }
    public void OnLeft()
    {
        transform.Find("body").transform.localScale = new Vector3(-1, 1,1);
        //sprite.flipX = true;
        Debug.Log("왼쪽");
    }
    public void OnRight()
    {
        
        //sprite.flipX = false;
        transform.Find("body").transform.localScale = new Vector3(1, 1, 1);
        Debug.Log("오른쪽");
    }

}
