using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Color;



public class Robot : MonoBehaviour
{
    [SerializeField] public LayerMask plateformelayermask;
    public Rigidbody2D rgb2D;
    float horizontal;
    float vertical;
    public float speed;
    public float jumpforce;
    Animator animator;
    public BoxCollider2D player_collider;
    static int currentPoint = 0;
    public static int maxBattery = 60;
    int currentBattery;
    public float fallMultiplier = 2.5f; 
    public float lowJumpMultiplier = 2f;

    AudioSource audioSource;
    public GameObject lamp;
    Color currentColor;
    

    public Color getCurrentColor(){
        return currentColor;
    }
    public int getCurrentBattery(){
        return currentBattery;
    }
    public static int getMaxBattery(){
        return maxBattery;
    }

    public int getPoint()
    {
        return currentPoint;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentPoint = 0;
        currentBattery = maxBattery;
        currentColor = Color.white;
        audioSource= GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxisRaw("Horizontal"); 
        float moveBy = x * speed; 
        rgb2D.velocity = new Vector2(moveBy, rgb2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() || Input.GetKeyDown(KeyCode.Z) && IsGrounded())
        {
            rgb2D.velocity = new Vector2(rgb2D.velocity.x, jumpforce);
            if (rgb2D.velocity.y < 0)
            {
                rgb2D.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
                Debug.Log("ici");
            }
            else if (rgb2D.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                rgb2D.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
                
            }
        }

        horizontal = Input.GetAxis("Horizontal");
        
        
        
        animator.SetFloat("MoveX", horizontal);
    }

    private void FixedUpdate() {
        
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(player_collider.bounds.center, player_collider.bounds.size, 0f, Vector2.down , .3f, plateformelayermask);
        Debug.Log(raycast.collider);
        return raycast.collider != null;
    }

    public void ChangePoint(int amount)
    {
        currentPoint += amount; 
        Counter.setTotal(currentPoint);
        Debug.Log(currentPoint);
                
    }

    public void ChangeBattery(int amount){
        currentBattery = Mathf.Clamp(currentBattery + amount, 0, maxBattery);
        LevelBar.recharge(amount);
        Debug.Log(currentBattery + "/" + maxBattery);
    }

    public void enablePowerYellow(){
       
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color= Color.yellow;
        currentColor = Color.yellow;
    }

    public void enablePowerCyan(){
        
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color= Color.cyan;
        currentColor = Color.cyan;
    }

    public void enablePowerGreen(){
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color= Color.green;
        currentColor = Color.green;
        Debug.Log(Color.green);
    }

    public void enablePowerTurquoise(){
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color = new Color(0.117f, 0.972f, 0.886f);
        currentColor = new Color(0.117f, 0.972f, 0.886f);
        Debug.Log("turquoise");

    }

    public void enablePowerWhite(){
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color= Color.white;
        currentColor = Color.white;
    }

    public void enablePowerGreenYellow(){
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color =new Color(0.843f,1f,0.07f);
        currentColor = new Color(0.843f,1f,0.07f);
    }
    
    public void addColor(Color c){
        lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color +=c;

    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    
}
