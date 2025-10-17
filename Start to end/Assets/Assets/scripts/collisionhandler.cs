using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class CollisionHandler : MonoBehaviour
{

    [SerializeField] capsule playerMovement;
    private float levelLoadDelay = 3f;
    AudioSource audioSource;
    [SerializeField] AudioClip successClip;
    [SerializeField] AudioClip deathClip;
    [SerializeField] AudioClip pointsClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "walls":
                Fail();
                break;
            case "Goal":
                Success();
                break;
            case "coins":
                Points();
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
        audioSource.PlayOneShot(successClip);
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    void Fail()
    {
        playerMovement.enabled = false;
        audioSource.Stop();
        audioSource.PlayOneShot(deathClip);
        Invoke("ReloadLevel", levelLoadDelay);
    }
    void Points()
    {
        playerMovement.enabled = false;
        audioSource.Stop();
        audioSource.PlayOneShot(successClip);
        Invoke("LoadNextLevel", levelLoadDelay);
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
