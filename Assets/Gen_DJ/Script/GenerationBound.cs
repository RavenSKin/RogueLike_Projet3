using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GenerationBound : MonoBehaviour
{
    GameObject container;
    GameObject[] LeftRay;
    GameObject[] RightRay;
    GameObject[] NorthRay;
    GameObject[] SouthRay;
    public RoomManager _rmActive;
    public DisableDoor _disableDoor;
    protected bool IsGenFinished;
    float WaitToGetInfo;
    public bool IsGenGood;
     public float WaitToGetRooms;
    public float WaitToFindBossRoom;
     string numberOfRooms;
     bool TimerEnded;
     bool SecTimerEnded;
     bool ManageResetting;
     bool Create1Room;
    GameObject[] Rooms;
    GameObject Placebo;
    [Space]
    [Header("StartRoomInfo")]
    [Space]
    GameObject _Parent;

    [SerializeField] private GameObject StartRoom;
    [SerializeField] private Vector3 StartPosition;
    public List<GameObject> RoomList = new List<GameObject>();
    [Space]
    [Header("Room Info")]
    [Space]
    public GameObject BossRoom;

    int IsListEnded;
    [SerializeField] private int Numb_Of_Room;
    bool StopTheList;
    [SerializeField] private int MinRoom;
    [SerializeField] private int MaxRoom;
    // Start is called before the first frame update
    void Start()
    {
       
 _Parent = GameObject.FindGameObjectWithTag("P_Room");
        RoomList[0] = StartRoom;
        Rooms[0] = StartRoom;

    }

    // Update is called once per frame
    void Update()
    {
       
       //if(container.activeInHierarchy)
       Rooms = GameObject.FindGameObjectsWithTag("Room");
      
        GetTheListOfRoom();
        SetUpTheBossRoom();
        BossRoom = RoomList[RoomList.Count - 1];
        Numb_Of_Room = Rooms.Length;
       
       
    }
    public void GetTheListOfRoom()
    {
        if (!TimerEnded)    // Timer Ended est en false de base
        {
            WaitToGetRooms += Time.deltaTime;
        }
        if (WaitToGetRooms >= 2)
        {
            TimerEnded = true;      // arrete le timer 

            if (!StopTheList)   //StopTheList est en false de base
            {
                RoomList.AddRange(Rooms);
            }

            if (RoomList.Count > Rooms.Length)  // Arrete la liste qui continu a l'infini en repetant le pattern
            {
                StopTheList = true;
            }

            if (StopTheList == true && RoomList.Count > Rooms.Length)   // Si la liste est arreté et que le nombre de salle stocké > au nombre de salle total
            {
                RoomList.RemoveAt(Rooms.Length);        // Enleve des elements jusqu'a obtenir une liste non répété
            }


        }
    }
    public void SetUpTheBossRoom()
    {
       
        if (TimerEnded && !SecTimerEnded)   // Au bout de 2 secondes execute le 2ieme timer
        {
            WaitToFindBossRoom += Time.deltaTime;
        }
        if (WaitToFindBossRoom >= 2)   
        { if ( Numb_Of_Room >= MinRoom && Numb_Of_Room <= MaxRoom)
        {
                IsGenGood = true;
                _disableDoor.enabled = true;
            _rmActive.enabled=true;
        } 
            // RESET TOUT SI LE NOMBRE DE SALLE N'EST PAS COMPRIS ENTRE MinRoom et MaxRoom
            if (Numb_Of_Room < MinRoom) 
            { SecTimerEnded = true;
               // StartCoroutine(WaitToInitiate());
                if (!Create1Room)
                {
                    DestroyAllGO();
                    StartCoroutine(WaitToInitiate());
                    CreateRoom();
                    ResetBooleans();

                }
                 
                Debug.LogWarning("Generation fausse");

            }
            if (Numb_Of_Room > MaxRoom)
            {
                SecTimerEnded = true;
                if (!Create1Room)
                {
                DestroyAllGO();
                StartCoroutine(WaitToInitiate());
                    CreateRoom();
                    ResetBooleans();
                }
                Debug.LogWarning("Generation fausse");
            }

            
                  // STOP LE TIMER SI TIMER 2 = 2 
              WaitToFindBossRoom = 0;   // RESET LE TIMER 2
            


        

        }
                    // RESET SECTION

        void DestroyAllGO()
        {

            _Parent.SetActive(false);
            RoomList.Clear();

        }
        void CreateRoom()
        {
            for (int i = 0; i < 1; i++)
            {
                //  RoomList.Clear();
                RoomList.Add(StartRoom);
                Rooms[0] = StartRoom;
                Instantiate(StartRoom, StartPosition, Quaternion.identity);
                Create1Room = true;
                
                _Parent = GameObject.FindGameObjectWithTag("P_Room");


            }
        }
        IEnumerator WaitToInitiate()
        {
            yield return new WaitForSeconds(0.5f);
        }
        void ResetBooleans()
        {WaitToGetRooms = 0;
                WaitToFindBossRoom = 0;
            TimerEnded = false;
            SecTimerEnded = false;
            StopTheList = false;
            Create1Room = false;
        }

    }
    void DisableRightRay()
    {
        foreach (GameObject R_Ray in RightRay)
        {
            R_Ray.SetActive(false);
        }
    }
    void DisableLeftRay()
    {
        foreach (GameObject L_Ray in LeftRay)
        {
            L_Ray.SetActive(false);
        }
    }
    void DisableTopRay()
    {
        foreach (GameObject T_Ray in NorthRay)
        {
            T_Ray.SetActive(false);
        }
    }
    void DisableBotRay()
    {
        foreach (GameObject S_Ray in SouthRay)
        {
            S_Ray.SetActive(false);
        }
    }
}