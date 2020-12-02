using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //아이디 인풋 필드
    public InputField id;

    //패스워드 인풋 필드
    public InputField password;

    // 상태 메세지 텍스트
    public Text message;


    void Start()
    {
        //상태 메시지를 공백으로 놓는다.
        message.text = "";
    }
    //새로 생성 버튼 함수
    /*public void SaveUserData()
    {

        if(CheckInputField(id.text, password.text))
        {
            message.text = "아이디 또는 패스워드를 입력해주세요";
            return;
        }

        if (!PlayerPrefs.HasKey(id.text))
        {
            PlayerPrefs.SetString(id.text, password.text);
            message.text = "아이디와 패스워드가 저장되었습니다";
        }
        else
        {
            message.text = "동일한 아이디가 존재합니다";
        }
    }*/
    
    //로그인 버튼 함수
    public void CheckUserData()
    {
        if (CheckInputField(id.text, password.text))
        {
            message.text = "아이디 또는 패스워드를 입력해주세요";
            return;
        }

        //사용자의 아이디와 패스워드 입력을 받아서 저장하는 기능
        //기존에 저장된 아이디가 아니여야 함
        string pass = PlayerPrefs.GetString(id.text);

        if(pass == password.text)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            message.text = "아이디 또는 패스워드가 잘못되었습니다.";
        }
    }

    //공백입력 검사
    bool CheckInputField(string id, string pwd)
    {
        if(id == ""||pwd == "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}