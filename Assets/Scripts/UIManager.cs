using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text enchanceOK;
    public Text susText;

    public AudioClip destroyClip;
    public AudioClip failClip;
    public AudioClip successClip;
    public AudioClip buttonClip;

    public int enhanceScore;
    public bool destroy;
    public bool isPerfect;

    private void Update()
    {
        Destroy();
        TextEnhance();
    }

    void TextEnhance()
    {
        enchanceOK.text = "+" + enhanceScore + " 강";
    }

    void Destroy()
    {
        if (destroy == true || enhanceScore <= 0)
        {
            enhanceScore = 0;
            destroy = false;
            susText.text = "파괴되었습니다.";
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PerfectMode()
    {
        isPerfect = !isPerfect;
    }

    public void EnhanceReset()
    {
        //SoundManager.instance.SFXPlay("Button", buttonClip);
        enhanceScore = 0;
    }

    public void EnhanceRandom()
    {
        //SoundManager.instance.SFXPlay("Button", buttonClip);
        switch (enhanceScore)
        {
            case 0: SwitchEnhance1(); break;
            case 1: SwitchEnhance2(); break;
            case 2: SwitchEnhance3(); break;
            case 3: SwitchEnhance4(); break;
            case 4: SwitchEnhance5(); break;
            case 5: SwitchEnhance6(); break;
            case 6: SwitchEnhance7(); break;
            case 7: SwitchEnhance8(); break;
            case 8: SwitchEnhance9(); break;
            default:
                SwitchEnhanceDe();
                break;
        }
    }

    void SwitchEnhanceDe()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 1) // 10%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 90%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance1()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 9) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance2()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 8) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance3()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 7) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance4()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 6) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance5()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 5) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance6()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 4) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance7()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 3) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance8()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 2) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }

    void SwitchEnhance9()
    {
        int ranEnhance = Random.Range(0, 10);

        if (ranEnhance < 1) // 90%
        {
            enhanceScore++;
            susText.text = "성공!";
            SoundManager.instance.SFXPlay("Success", successClip);
        }
        else if (ranEnhance < 10 && (isPerfect == true)) // 10%
        {
            int ran = Random.Range(0, 2);

            if (ran < 1)
            {
                enhanceScore--;
                susText.text = "실패!";
                SoundManager.instance.SFXPlay("Fail", failClip);
            }
            else if (ran < 2)
            {
                destroy = true;
                SoundManager.instance.SFXPlay("Destroy", destroyClip);
            }
        }
    }
}