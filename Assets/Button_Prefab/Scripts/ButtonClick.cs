using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    // 버튼마다 다른 대회가 출력되도록 배열에 저장, 단 버튼은 하나만 만든다.
    [SerializeField] private string[] messages;


    private void Start()
    {
        // 현재 게임 오브젝트에서 Button 컴포넌트 배열을 가져온다.
        Button[] buttons = GetComponentsInChildren<Button>();

        // 버튼의 개수와 메시지의 개수가 동일한지 확인
        if (buttons.Length != messages.Length)
        {
            Debug.LogWarning("버튼의 개수와 메시지의 개수가 일치하지 않습니다. 메시지의 개수와 버튼의 개수를 일치하도록 만들어주세요.");
            return;
        }

        // 각 버튼(배열의 크기)에 대한 클릭 이벤트 리스너 등록
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // 클로저 문제를 피하기 위해 지역 변수 사용
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    // 버튼 클릭 시 호출되는 함수
    private void OnButtonClicked(int index)
    {
        // 지정된 메시지를 출력(인스펙터뷰에 입력)
        Debug.Log(messages[index]);
    }
}
