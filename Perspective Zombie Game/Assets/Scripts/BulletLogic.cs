using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    [SerializeField] Camera             MainCameraPlayer;
    [SerializeField] LayerMask          GroundMask;
    [SerializeField] GameObject          PlayerGO;

                     private Vector3    BulletTarget;
                     public  float      BulletTime = 5f;
                     public  float      Range = 25f;
    

    // Start is called before the first frame update
    void Start()
    {

        MainCameraPlayer = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        PlayerGO = GameObject.FindWithTag("Player");
        BulletLogicTarget();
            
            
  

    }

    // Update is called once per frame
    void LateUpdate()
    {
       BulletTargetTravel();  
       BulletTime -= 10f *Time.deltaTime;

    }

    

            public void BulletLogicTarget()
            {

                Physics.Raycast(PlayerGO.transform.position,PlayerGO.transform.forward, out RaycastHit Hitplace, Range);
                BulletTarget = Hitplace.point;
                BulletTarget.y += 0.5f;
            }
            
            void BulletTargetTravel()
            {

                transform.position = Vector3.MoveTowards(transform.position, BulletTarget, 1f);
                transform.LookAt(BulletTarget);
                if(BulletTime <= 0f)
                {
                    Destroy(gameObject);
                }

            }


                // This code was based on Cursor placement
                //Physics.Raycast(MainCameraPlayer.ScreenPointToRay(Input.mousePosition), out RaycastHit hitlocation,float.MaxValue,GroundMask);
                //BulletTarget = hitlocation.point;
                //BulletTarget.y += 0.5f;
                

}


