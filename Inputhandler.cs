using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ RequireComponent(typeof(Rigidbody2D))]
public class Inputhandler : MonoBehaviour
{
    [SerializeField] private LayerMask PlatformLayerMask;


    Playercontroller inputactions;

    int jumppara;
    Animator anim;
    int walkpara;
    int leftpara;

    bool wassound = false;

    State CurrentState;

    [SerializeField]
    public float speed = 200f;
    [SerializeField]
    public float Jump = 500f;

    Scene whatslevel;

   // Scene whatslevel;

    float Leftright = 0f;
    float hPrev = 0f;
    float hNew = 0f;

    float Updown = 0f;
    float vPrev = 0f;
    float vNew = 0f;

    public Rigidbody2D Player;
    public BoxCollider2D box;

    private void Awake()
    {
        inputactions = new Playercontroller();

        inputactions.Keyboardwasd.Leftright.performed += ctx => Leftright = ctx.ReadValue<float>();
       // inputactions.Keyboardwasd.Leftright.
        //keyup and keydown for jump
        inputactions.Keyboardwasd.Updown.performed += ctx => Updown = ctx.ReadValue<float>();
        inputactions.Keyboardwasd.Updown.canceled += ctx => Updown = ctx.ReadValue<float>();

        Player = GetComponent<Rigidbody2D>();

        box = GetComponent<BoxCollider2D>();

        anim = GetComponent<Animator>();

        whatslevel = new Scene();

       // Debug.Log(whatslevel.ToString);

        //jumppara is string?
        jumppara = Animator.StringToHash("Jumping");
        //slidepara = Animator.StringToHash("Slide");
        leftpara = Animator.StringToHash("faceleft");
        walkpara = Animator.StringToHash("walking");
    }

    // Start is called before the first frame update
    void Start()
    {
   
    }

    void Update()
    {
        whatslevel = SceneManager.GetActiveScene();
       
    }

    private void OnEnable()
    {
        inputactions.Keyboardwasd.Enable();
    }

    private void OnDisable()
    {
        inputactions.Keyboardwasd.Disable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            SoundScript.playeffect("coin");
            Destroy(collision.gameObject);
        }
    }
    private void inputsystem()
    {
        //Debug.log
        hNew = Leftright;
        vNew = Updown;
        float hDelta = hNew - hPrev;
        float vDelta = vNew - vPrev;

       if (vNew == 1)
        {
            SoundScript.playeffect("playerJumpSound");
        }

        //Debug.Log(hNew);
        if (hPrev < 0)
        {
            transform.localScale = new Vector3((float)-3.38921, transform.localScale.y);
            
            anim.SetBool(leftpara, false);
           
        }
        else if (hPrev > 0)
        {
            transform.localScale = new Vector3((float)3.38921, transform.localScale.y);
            anim.SetBool(leftpara, true);
          
        }
        else if (hNew != 0)
        {
            anim.SetBool(walkpara, true);
        }
        else
        {
            anim.SetBool(walkpara, false);
        }

      

        /* if (Mathf.Abs(hDelta) > 0f && Mathf.Abs(hNew) > 0f && (CurrentState == State.RunR || CurrentState == State.RunL))
         {

         }*/
        Vector2 force = Vector2.zero;

       
      
            if (!IsGrounded())
            {
            if (!wassound)
            {
               
                wassound = true;
            }
           // 
           
            force = new Vector2((hNew * speed), (0));

            }
        else {

                wassound = false;
                force = new Vector2((hNew * speed), (vNew * Jump));
            
               
            }
        
       //if(GameManager)
       if (whatslevel.Equals(SceneManager.GetSceneByName("Level9")))
        {

            if (IsGrounded())
            {
                SceneManager.LoadScene("Level9");


            }
          
        }

        if (force != Vector2.zero)
        {
            //Debug.Log(force);
            Player.AddForce(force);

            // force -= new Vector2(1,1);

        }
       
       // Debug.Log(force);

        /*if (jump == 1f && CurrentState == State.Run)
        {
            CurrentState = State.Jump;
            StartCoroutine(Jump());
        }*/


        Leftright = 0f;
        Updown = 0f;

        //jump = 0f;

        hPrev = hNew;
        vPrev = vNew;

     

    }

   public bool IsGrounded()
    {
        float extra = 1f;
        RaycastHit2D hit = Physics2D.BoxCast(box.bounds.center, box.bounds.size,0f, Vector2.down,extra,PlatformLayerMask); //box.bounds.extents.y + extra);
        Color raycolor;
        if (hit.collider != null)
        {
            raycolor = Color.green;
          
        }
        else
        {
            raycolor = Color.red;
           
        }

        Debug.DrawRay(box.bounds.center, Vector2.down, raycolor);
       // Debug.Log(hit.collider);
        return hit.collider != null;

    }

    private void MovePlayer(int h,int v)
    {
        //Debug.Log("Problem with position code");
        Vector3 fromPosition = transform.position;
        Vector3 toPosition = new Vector3(transform.position.x + h * speed, transform.position.y + v);
       // transform.position.x + h * speed,transform.position.y + v
        //Debug.Log(v + " " + h); //v and h are always 0, this is problem.
        for (float t = 0f; t < 1f; t += speed * Time.deltaTime )
        {
            transform.position = Vector3.Lerp(fromPosition,toPosition,t);
           

        }
    }

    // Update is called once per frame
   


    void FixedUpdate()
    {
        if (Player != null)
        {
            inputsystem();

        }
        else
        {
            Debug.LogWarning("Player rigidbody not Found" + gameObject.name);
        }

        //Debug.Log(IsGrounded());

        if (IsGrounded())
        {
            anim.SetBool(jumppara, false);
        }
        else
        {
            anim.SetBool(jumppara, true);
        }

        //sprite doesn't appear to show up until movement key is pressed.
        // bug where sprites don't appear applies to all sprites
    }

}
