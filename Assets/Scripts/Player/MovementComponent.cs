using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float speed;
    [SerializeField] private float jumpforce;
    [SerializeField] private List<GameObject> ThingsImIncontactWith = new List<GameObject>();
    [SerializeField] private ColorHolder myColor;
    private float inputValue = 0;
    private Vector3 MoveDirection = Vector3.zero;
    [SerializeField] private int health = 3;
    private Rigidbody rigidbody;
    [SerializeField]
    int points = 0;
    [SerializeField]
    List<GameObject> TookDamageFrom = new List<GameObject>();
    PlatformManager platformManager;
    [SerializeField]
    TextMeshProUGUI PointsText;
    [SerializeField]
    TextMeshProUGUI LivesText;
    [SerializeField]
    GameObject InGameUI;
    [SerializeField]
    GameObject GameOverUI;
    [SerializeField]
    GameObject PauseUI;
    [SerializeField]
    TextMeshProUGUI GameOverPointsText;


    //
    private Animator animator;
    public readonly int JumpingHash = Animator.StringToHash("IsJumping");
    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        platformManager = GameObject.FindGameObjectWithTag("PlatformManager").GetComponent<PlatformManager>();
    }
    public void OnMovement(InputValue value)
    {
        inputValue = (float) value.Get();
        //Debug.Log(value.ToString());
        
    }

    public void OnPause (InputValue value)
    {
        if (health == 0)
            return;
        Debug.Log("PauseTriggered");
        if (PauseUI.activeInHierarchy)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Pause()
    {
        if (health == 0)
            return;
        if (PauseUI.activeInHierarchy)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnJump(InputValue value)
    {
        if (health == 0)
            return;
        if (playerController.isJumping)
            return;
        playerController.isJumping = value.isPressed;
        animator.SetBool(JumpingHash, value.isPressed);
        rigidbody.AddForce((transform.up) * jumpforce, ForceMode.Impulse);

    }

    private void Update()
    {
        if (health == 0)
            return;
        if (inputValue.Equals(0))
        {
            //realign player
            MoveDirection = Vector3.zero;
            return;
        }
        if (playerController.isJumping)
        {
            MoveDirection = transform.right * inputValue;
            Vector3 movementDir = MoveDirection * (speed * Time.deltaTime);
            rigidbody.velocity = rigidbody.velocity + movementDir;
        }
        else
        {
            MoveDirection = transform.right * inputValue;
            Vector3 movementDir = MoveDirection * (speed * Time.deltaTime);
            transform.position += movementDir;
        }
    }

    private void FixedUpdate()
    {
        if (health == 0)
        {
            GameOverUI.SetActive(true);
            InGameUI.SetActive(false);
            GameOverPointsText.text = points.ToString();
            return;
        }
        bool wrongcolor = false;
        foreach (GameObject platform in ThingsImIncontactWith)
        {
            if (platform.GetComponent<ColorHolder>().color == myColor.color)
            {
                points +=  10 * (int)platformManager.speed;
                PointsText.text = points.ToString();
            }
            if (!TookDamageFrom.Contains(platform))
            {
                if (platform.GetComponent<ColorHolder>().color != myColor.color)
                {
                    Debug.Log("not my color");
                    if (platform.GetComponent<ColorHolder>().color != PlatformColor.White)
                    {
                        Debug.Log("not White");
                        wrongcolor = true;
                        TookDamageFrom.Add(platform);
                    }
                }
            }
            if (wrongcolor)
            {
                health--;
                switch(health)
                {
                    case 3:
                        LivesText.text = "X X X";
                        break;
                    case 2:
                        LivesText.text = "X X";
                        break;
                    case 1:
                        LivesText.text = "X";
                        break;
                    default:
                        LivesText.text = "";
                        break;
                }
            }
            if (health <= 0)
            {
                Debug.Log("Dead Player");
                //change screen?
            } 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathPlane"))
            health = 0;
        if (!collision.gameObject.CompareTag("Ground") && !playerController.isJumping)
            return;

        playerController.isJumping = false;
        animator.SetBool(JumpingHash, false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
            health = 0;
        if (other.gameObject.CompareTag("Ground"))
            ThingsImIncontactWith.Add(other.gameObject );
    }
    private void OnTriggerExit(Collider other)
    {
        ThingsImIncontactWith.Remove(other.gameObject);
    }
}
