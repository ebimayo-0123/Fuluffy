using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
 
public class Timer : MonoBehaviour {
 
	//�@�g�[�^����������
	private float totalTime;
	//�@�������ԁi�b�j
	[SerializeField]
	private float seconds;
	//�@�O��Update���̕b��
	private float oldSeconds;
	private TextMeshProUGUI timerText;
    private Rigidbody2D rb2d;
 
	void Start () {
        seconds=10f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<TextMeshProUGUI>();
        rb2d = GameObject.Find("Player").GetComponent<Rigidbody2D>();
	}
 
	void Update () {
        if(rb2d.isKinematic == false)
        {
            //�@�������Ԃ�0�b�ȉ��Ȃ牽�����Ȃ�
            if (seconds <= 0f) {
                return;
            }
            //�@��U�g�[�^���̐������Ԃ��v���G
            seconds -= Time.deltaTime;
    
            //�@�Đݒ�
    
            //�@�^�C�}�[�\���pUI�e�L�X�g�Ɏ��Ԃ�\������
            if((int)seconds != (int)oldSeconds) {
                timerText.text = ((int)seconds).ToString();
            }
            oldSeconds = seconds;
            //�@�������Ԉȉ��ɂȂ�����R���\�[���Ɂw�������ԏI���x�Ƃ����������\������
            if(seconds <= 0f) {
                Debug.Log("�������ԏI��");
            }
	    }
    }
}