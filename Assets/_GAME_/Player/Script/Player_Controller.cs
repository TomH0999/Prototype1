using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

[SelectionBase]
public class Player_Controller : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Atributes")]
    [SerializeField] float _moveSpeed = 50f;
    
    [Header("Depedencies")]
    [SerializeField] Rigidbody2D _rb;
    #endregion

    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    #endregion

    private void Update()
    {
        GatherInput();
    }

    [System.Obsolete]
    private void FixedUpdate() => MovementUpdate();

    #region Input Logic
    private void GatherInput()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.y = Input.GetAxisRaw("Vertical");

        print(_moveDir);
    }
    #endregion

    #region movement Logic
    [System.Obsolete]
    private void MovementUpdate() => _rb.velocity = _moveSpeed * Time.fixedDeltaTime * _moveDir;
    #endregion
}
