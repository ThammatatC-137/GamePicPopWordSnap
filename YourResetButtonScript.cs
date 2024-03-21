using UnityEngine;

public class YourResetButtonScript : MonoBehaviour
{
    public QuizManager quizManager;

    private void Start()
    {
        // อ้างอิง QuizManager จาก GameObject ในฉาก
        quizManager = GameObject.FindObjectOfType<QuizManager>();

        // ตรวจสอบว่า QuizManager ถูกพบหรือไม่
        if (quizManager == null)
        {
            Debug.LogError("QuizManager not found in the scene.");
        }
    }

    public void OnResetButtonClicked()
    {
        // เรียกใช้ฟังก์ชัน ResetLastWord() ใน QuizManager
        quizManager.ResetLastWord();
    }
}

