using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHandler : MonoBehaviour
{
    [SerializeField]
    PlayerController pc;

    [SerializeField]
    AudioSource C4ClarinetAudio;
    [SerializeField]
    AudioSource D4ClarinetAudio;
    [SerializeField]
    AudioSource E4ClarinetAudio;
    [SerializeField]
    AudioSource F4ClarinetAudio;
    [SerializeField]
    AudioSource G4ClarinetAudio;
    [SerializeField]
    AudioSource A4ClarinetAudio;
    [SerializeField]
    AudioSource B4ClarinetAudio;
    [SerializeField]
    AudioSource C5ClarinetAudio;

    [SerializeField]
    int currentKeyNumber;
    [SerializeField]
    int lastKeyNumber;
    [SerializeField]
    int lastInterval;
    [SerializeField]
    int currentInterval;
    [SerializeField]
    bool currentIntervalPositive;

    public void C4Play()
    {
        C4ClarinetAudio.Play();
        currentKeyNumber = 40;
    }
    public void C4Stop()
    {
        C4ClarinetAudio.Stop();
        //lastKeyNumber = 40;
    }
    public void D4Play()
    {
        D4ClarinetAudio.Play();
        currentKeyNumber = 42;
    }
    public void D4Stop()
    {
        D4ClarinetAudio.Stop();
        //lastKeyNumber = 42;
    }
    public void E4Play()
    {
        E4ClarinetAudio.Play();
        currentKeyNumber = 44;
    }
    public void E4Stop()
    {
        E4ClarinetAudio.Stop();
        //lastKeyNumber = 44;
    }
    public void F4Play()
    {
        F4ClarinetAudio.Play();
        currentKeyNumber = 45;
    }
    public void F4Stop()
    {
        F4ClarinetAudio.Stop();
        //lastKeyNumber = 45;
    }
    public void G4Play()
    {
        G4ClarinetAudio.Play();
        currentKeyNumber = 47;
    }
    public void G4Stop()
    {
        G4ClarinetAudio.Stop();
        //lastKeyNumber = 47;
    }
    public void A4Play()
    {
        A4ClarinetAudio.Play();
        currentKeyNumber = 49;
    }
    public void A4Stop()
    {
        A4ClarinetAudio.Stop();
        //lastKeyNumber = 49;
    }
    public void B4Play()
    {
        B4ClarinetAudio.Play();
        currentKeyNumber = 51;
    }
    public void B4Stop()
    {
        B4ClarinetAudio.Stop();
        //lastKeyNumber = 51;
    }
    public void C5Play()
    {
        C5ClarinetAudio.Play();
        currentKeyNumber = 52;
    }
    public void C5Stop()
    {
        C5ClarinetAudio.Stop();
        //lastKeyNumber = 52;
    }

    public void StopAllNotes()
    {
        C4ClarinetAudio.Stop();
        D4ClarinetAudio.Stop();
        E4ClarinetAudio.Stop();
        F4ClarinetAudio.Stop();
        G4ClarinetAudio.Stop();
        A4ClarinetAudio.Stop();
        B4ClarinetAudio.Stop();
        C5ClarinetAudio.Stop();
    }
    private void Start()
    {

    }

    private void CheckCurrentInterval()
    {
        if (currentKeyNumber >= lastKeyNumber)
        {
            currentIntervalPositive = true;
        }
        else
        {
            currentIntervalPositive = false;
        }
    }

    private void Update()
    {

        lastInterval = (Mathf.Abs(currentKeyNumber - lastKeyNumber));

        if (Input.GetKeyDown(KeyCode.A))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            C4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            C4Stop();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            D4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            D4Stop();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            E4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            E4Stop();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            F4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            F4Stop();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            G4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            G4Stop();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            A4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            A4Stop();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            B4Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            B4Stop();
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            StopAllNotes();
            lastKeyNumber = currentKeyNumber;
            C5Play();
            CheckCurrentInterval();

            if (currentIntervalPositive)
            {
                pc.Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            C5Stop();
        }
    }
}
