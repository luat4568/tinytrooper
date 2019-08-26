using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public CharacterDataBinding dataBinding;
    private Vector2 tempMoveDir;
    private Transform trans;
    public float speed = 2f;
    public List<AnimatorOverrideController> lsAnim;
    // Start is called before the first frame update
    void Start()
    {
        trans = transform;
        dataBinding.ChangeGunAnim(lsAnim[0]);
    }

    // Update is called once per frame
    void Update()
    {
        float x = InputManager.moveDir.x;
        float y = InputManager.moveDir.y;
        x = Mathf.Round(x);
        y = Mathf.Round(y);
        Vector3 posMove = new Vector3(x, y, trans.position.z);
        Vector2 move = new Vector2(x, y);
       
        float speedMove = move.magnitude;
        speedMove = Mathf.RoundToInt(speedMove);
        if(speedMove>0)
        {
          
            Vector2 newMoveDir = new Vector2(x, y);
            if (tempMoveDir != newMoveDir)
            {

                tempMoveDir = newMoveDir;
            }
            dataBinding.MoveDir = tempMoveDir;
        }
      
        dataBinding.SpeedMove = speedMove;

        trans.position = Vector3.MoveTowards(trans.position,trans.position+ posMove,
         speedMove * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Z))
        {
            dataBinding.ChangeGunAnim(lsAnim[0]);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            dataBinding.ChangeGunAnim(lsAnim[1]);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            dataBinding.ChangeGunAnim(lsAnim[2]);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            dataBinding.ChangeGunAnim(lsAnim[3]);
        }
    }
}
