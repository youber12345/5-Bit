using UnityEngine;
using UnityEngine.UI;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // 바꿀 커서의 텍스처
    public Button changeCursorButton; // 커서를 바꾸는 버튼
    public Button changeImageButton; // 이미지를 바꾸는 버튼
    public Sprite newSprite; // 바꿀 스프라이트
    public AudioClip gunshotSound; // 총소리 클립

    private bool isCursorChanged = false;
    private Vector2 hotSpot = Vector2.zero; // 커서의 중심점을 설정합니다.
    private CursorMode cursorMode = CursorMode.Auto; // 커서 모드를 설정합니다.
    public AudioSource audioSource; // 오디오 소스
    public AudioSource audioSource1; // 오디오 소스

    public AudioClip backgroundMusic;


    public Button interactableButton;
    public Button interactableButton2;

    public GameObject newImageObject; // 새로운 이미지 오브젝트
    public GameObject newImageObject1; // 새로운 이미지 오브젝트

    void Start()
    {
        // 오디오 소스 컴포넌트를 가져옵니다.
        audioSource = GetComponent<AudioSource>();

        // 각 버튼의 클릭 이벤트에 함수를 연결합니다.
        changeCursorButton.onClick.AddListener(ChangeCursor);
        changeImageButton.onClick.AddListener(ActivateImage);

        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isCursorChanged)
        {
            ActivateImage();
        }
    }

    void ChangeCursor()
    {
        // 커서를 바꿉니다.
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        isCursorChanged = true;
    }



    void ActivateImage()
    {
        if (isCursorChanged)
        {
            changeImageButton.GetComponent<Image>().sprite = newSprite;
            changeImageButton.interactable = false; // 버튼을 비활성화합니다.

            // 총소리를 재생합니다.
            audioSource.PlayOneShot(gunshotSound);

            audioSource1.clip = backgroundMusic;
            audioSource1.Play();

            Button[] allButtons = FindObjectsOfType<Button>();
            foreach (Button button in allButtons)
            {
                button.interactable = false;
            }

            // 특정 버튼만 다시 활성화합니다.
            interactableButton.interactable = true;
            interactableButton2.interactable = true;

            isCursorChanged = true; // 이미지가 바뀌었으므로 isCursorChanged를 true로 설정합니다.
            
            isCursorChanged = false; // 이미지가 활성화되었으므로 isCursorChanged를 false로 설정합니다.

            newImageObject.SetActive(true);
            newImageObject1.SetActive(true);
        }
    }

}
