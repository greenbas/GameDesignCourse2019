using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogre : MonoBehaviour
{
    public int intel = 5;
    public bool headBlow = false;
    public bool readBook = false; 
    void Greet()
    {
        switch (intel)
        {
            case 5:

                if (headBlow)
                {
                    intel--;
                    print("OW! You bloody wot, mate?");
                    headBlow = false;
                    Greet();
                }
                else if (readBook)
                {
                    print("No thank you, I find clifford to be a bit pedestrian these days");
                    readBook = false;
                    Greet();
                }
                else print("Hello, my friend! Do you like physics?");
                break;
            case 4:

                if (headBlow)
                {
                    intel--;
                    print("OI! What the hell!?");
                    headBlow = false;
                    Greet();
                }
                else if (readBook)
                {
                    intel++;
                    print("Always time for a good read!");
                    readBook = false;
                    Greet();
                }
                else print("Ello, guv! Fine day out, innit?");
                break;
            case 3:

                if (headBlow)
                {
                    intel--;
                    print("STOP HITTING MY HEAD!!");
                    headBlow = false;
                    Greet();
                }
                else if (readBook)
                {
                    intel++;
                    print("Alright, why's this dog so red then, aye?");
                    readBook = false;
                    Greet();
                }
                else print("Wot u want?");
                break;
            case 2:

                if (headBlow)
                {
                    intel--;
                    print("RAWWR!!");
                    headBlow = false;
                    Greet();
                }
                else if (readBook)
                {
                    intel++;
                    print("Hahah, dog big!");
                    readBook = false;
                    Greet();
                }
                else print("Ugh, ugh... me want food");
                break;
            case 1:

                if (headBlow)
                {
                    intel--;
                    headBlow = false;
                    print("*incoherent screaming*");
                    Greet();
                }
                else if (readBook)
                {
                    intel++;
                    readBook = false;
                    print("*attempts to eat paper*");
                    Greet();
                }
                else
                    print("Grrr...*fart*");
                break;
            default:

                if (headBlow)
                {
                    print("*no response*");
                    headBlow = false;
                    Greet();
                }
                else if (readBook)
                {
                    intel = 1;
                    readBook = false;
                    print("*The ogre stares at the book*");
                    Greet();
                }
                else 
                    print("*drools*");
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Greet();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            headBlow = true;
            Greet();
        }
        if (Input.GetKeyDown("r"))
        {
            readBook = true;
            Greet();
        }

    }
}
