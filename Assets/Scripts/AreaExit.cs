using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] string sceneToLoad;

    [SerializeField] string transitionName;
    [SerializeField] AreaEnter areaEnter;


    // Start is called before the first frame update
    void Start()
    {
        areaEnter.transitionAreaName = transitionName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().transitionName = transitionName;
            MenuManager.self.FadeImage();
            StartCoroutine(LoadSceneCoroutine());

        }
    }

    IEnumerator LoadSceneCoroutine()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(sceneToLoad);
    }
}
