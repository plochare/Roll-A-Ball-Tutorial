using UnityEngine;
using UnityEngine.UI;

public class PrefabScript : MonoBehaviour
{
    public GameObject prefab; // Assign in Inspector
    public Slider scaleSlider;

    void Start()
    {
        SpawnPrefab(new Vector3(0f,2f,0f));
        SpawnPrefab(new Vector3(2f,2f,2f));
        //
        RandomPrefab();
        RandomPrefab();
        // For loop call 10 times;s
        for (int i=0;i<10;i++){
            RandomPrefab();
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Keyboard Event
         if (Input.GetKeyDown(KeyCode.Space)){
            RandomPrefab();
         }

        // Mouse Event
        if (Input.GetMouseButtonDown(0)){
            RandomPrefab();
        }
    }

    public void RandomPrefab(){
        float randomX = Random.Range(-6f, 6f);
        float randomZ = Random.Range(-6f, 6f);
        SpawnPrefab(new Vector3(randomX,0f,randomZ));
    }

    void SpawnPrefab(Vector3 _spawnPos){
        float scaleVal = scaleSlider.value + 1f;
        // Spawn prefab and set position
        GameObject myPrefab = Instantiate(prefab);
        myPrefab.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);
        myPrefab.transform.position = _spawnPos;
    }
}
