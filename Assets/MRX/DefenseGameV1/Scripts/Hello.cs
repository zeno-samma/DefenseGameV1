using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // public Transform myTransform;
    public GameObject EnemyPrefabs;
    public SpriteRenderer sp;
    public Transform myTransfrom;
    public Hello hello;
    float score;
    private void Awake()
    {
        // Debug.Log("Awake");
        //Get component script
        // sp = GetComponent<SpriteRenderer>();
        // sp.color = Color.blue;
    }
    private void OnEnable()
    {
        // Debug.Log("OnEnable");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Start");
        // myTransform.position = new Vector3(3, 3, 0);
        // if (EnemyPrefabs) //Check object # null
        // {
        //     // Create object
        //     var enemyClone = Instantiate(EnemyPrefabs, new Vector3(2, 2, 0f), Quaternion.identity);
        //     // Destroy object after 5s
        //     Destroy(enemyClone, 5f);
        // }
        // Get component inspector
        // if (sp)
        // {
        //     sp.color = Color.red;
        // }
        // StartCoroutine("DemoIE");
        // StartCoroutine(DemoIE());//Delay action hard
        // Invoke("Work", 1f);//Delay action basic
        //Save score in mycomputer
        score = PlayerPrefs.GetFloat("Score", 0);
        score += 10;
        PlayerPrefs.SetFloat("Score", score);
        Debug.Log("Điểm số : " + score);

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello Update");
        // Debug.Log(gameObject.transform);
    }

    private void OnDisable()
    {
        // Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        // Debug.Log("OnDestroy"); 
    }
    // //One hit 
    // private void OnCollisionEnter2D(Collision2D colTarget)
    // {
    //     // Debug.Log("Đối tượng va chạm là: " + colTarget.gameObject.tag);
    //     // colTarget.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    // }
    // //Frame by frame
    // private void OnCollisionStay2D(Collision2D colTarget)
    // {
    //     Debug.Log("Đối tượng va chạm là: " + colTarget.gameObject.tag);
    //     colTarget.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

    // }

    // private void OnTriggerEnter2D(Collider2D colTarget)
    // {
    //     Debug.Log("Đối tượng va chạm là: " + colTarget.gameObject.tag);
    //     colTarget.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    // }

    private IEnumerator DemoIE()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Thực hiện công việc 1");
        yield return new WaitForSeconds(2);
        Debug.Log("Thực hiện công việc 2");
    }
    private void Work()
    {
        Debug.Log("Thực hiện công việc 1");
    }

}
