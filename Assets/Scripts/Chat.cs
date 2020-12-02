using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    // Start is called before the first frame update

    public RectTransform AreaRect, BoxRect, TextRect;
    public GameObject Tail;
    public Text TimeText, UserText, DateText;
    public Image UserImage;
    public string Time, User;
}
