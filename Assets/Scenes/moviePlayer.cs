using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    moviePlayer movie;
    
    void Start()
    {
        movie = Get<>().material.mainTexture as MovieTexture;
        //Renderer에서 maintexture를 받아서 movio로 저장
        //컴퍼넌트에서 audiosource를 받아서 audio로 저장

        movie.Play();//동영상을 play 합니다
        //movie에서 audioClip을 받아 audio.clip에 저장
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
