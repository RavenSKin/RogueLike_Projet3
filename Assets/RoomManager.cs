using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject RoomSelected; 
    public GameObject GenBound;
    public int PotionRoom = 5;
    public int ChallengeRoom = 2;
    public int WeaponRoom = 3;
    public List<GameObject> Room_Setup = new List<GameObject>();
    
    int RandomizeSelect;
    int RandomizeContain;
    bool NoPotion;
    bool NoWeapon;
    bool NoChallengeRoom;
   public bool StopCor;
    int RoomCount;
    public List<string> RoomEnabler = new List<string>();
    string RoomName;
    int BossRoomInList; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RoomEnabler[1]);
        BossRoomInList = Room_Setup.Count;
        Room_Setup = gameObject.GetComponent<GenerationBound>().RoomList;
        Room_Setup.Remove(Room_Setup[0]);
        Room_Setup.Remove(Room_Setup[BossRoomInList]);
    }

    // Update is called once per frame
    void Update()
    {
        CheckRoom();
        if (NoPotion && NoChallengeRoom && NoWeapon)
        {
            StopCor = true;
        }
        if (!StopCor)
        {
            StartCoroutine(Reroll());
        }
    }
    IEnumerator Reroll()
    {
        RandomizeContain = Random.Range(0, RoomEnabler.Count); // Selectionne un nombre aleatoire
        RoomCount = Random.Range(0, Room_Setup.Count);
        RoomName = RoomEnabler[RandomizeContain];   // Utilise le nombre aleatoire pour chercher dans la liste 
        if (RoomEnabler.Count == 1)
        {
            RandomizeContain = 0; // Si il ne reste plus qu'un objet dans la liste alors le chiffre sera forcement lui
        }
        if(RoomName == "Challenge")
        {
            RoomSelected = Room_Setup[RoomCount];   // La salle selectionné = 
            RoomSelected.transform.GetChild(5).gameObject.SetActive(true);
            Room_Setup.Remove(RoomSelected);
            ChallengeRoom--;
        }
        if(RoomName == "Potion")
        {
            RoomSelected = Room_Setup[RoomCount];
            RoomSelected.transform.GetChild(6).gameObject.SetActive(true);
            Room_Setup.Remove(RoomSelected);
            PotionRoom--;
        }
        if(RoomName == "Weapon")
        {
            RoomSelected = Room_Setup[RoomCount];
            RoomSelected.transform.GetChild(7).gameObject.SetActive(true);
            Room_Setup.Remove(RoomSelected);
            WeaponRoom--;
        }
        yield return new WaitForSeconds(0.1f);
    }
    void CheckRoom()
    {
        if (PotionRoom <= 0)
        {
            NoPotion = true;
        }
        if (ChallengeRoom <= 0)
        {
            NoChallengeRoom = true;
        }
        if(WeaponRoom <= 0)
        {
            NoWeapon = true;
        }
        if (NoPotion)
        {
            RoomEnabler.Remove(RoomEnabler[0]);
        }
        if (NoWeapon)
        {
            RoomEnabler.Remove(RoomEnabler[1]);
        }
        if (NoChallengeRoom)
        {
            RoomEnabler.Remove(RoomEnabler[2]);
        }

    }
}
