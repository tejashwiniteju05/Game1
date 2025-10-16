using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{

    [SerializeField] capsule playerMovement;
    private float levelLoadDelay = 3f;
    AudioSource audioSource;
    [SerializeField] AudioClip successClip;
    [SerializeField] AudioClip deathClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle":
                Fail();
                break;
            case "Finish":
                Success();
                break;
            default:
                Debug.Log("No Tag");
                break;
        }
    }

    void Success()
    {
        playerMovement.enabled = false;
        audioSource.Stop();
        audioSource.enabled=true;
        audioSource.PlayOneShot(successClip);
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    void Fail()
    {
        playerMovement.enabled = false;
        audioSource.Stop();
        audioSource.enabled = true;
        audioSource.PlayOneShot(deathClip);
        Invoke("ReloadLevel", levelLoadDelay);
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
