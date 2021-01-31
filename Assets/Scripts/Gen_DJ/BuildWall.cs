using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWall : CastRay
{
    public GameObject GenBound;
    public bool _StopCast;
    GameObject _Parent;
    public GameObject RoomMaster;
    [Space]
    public GameObject DeadEnd;
    [Space]
    public GameObject tunnel;
    [Space]
    public GameObject tunnelCulDeSac;
    [Space]
    public List<GameObject> SouthRoom = new List<GameObject>();
    [Space]
    public List<GameObject> NorthRoom = new List<GameObject>();
    [Space]
    public List<GameObject> RightRoom = new List<GameObject>();
    [Space]
    public List<GameObject> LeftRoom = new List<GameObject>();

   // public List<GameObject> RoomStorage = new List<GameObject>();
    private void Start()
    {
        
        Range = Offset * 2;
        GenBound = GameObject.Find("DungeonMaster");
        _Parent = GameObject.FindGameObjectWithTag("P_Room");
        SelectSouthRoom = Random.Range(0, SouthRoom.Count);
        SelectNorthRoom = Random.Range(0, NorthRoom.Count);
        SelectRightRoom = Random.Range(0, RightRoom.Count);
        SelectLeftRoom = Random.Range(0, LeftRoom.Count);
        
    }
    private void Update()
    {
        _StopCast = GenBound.GetComponent<GenerationBound>().IsGenGood;
        Cast();
        if (!_StopCast)
        {
            if (StartBuilding)
            {
                Build_DJ();
            }
        }
    }
    protected void Build_DJ()
    {
       
            if (gameObject.tag == "Top")
            {
                BuildTop();
            StartCoroutine(Wait2S());
            }
            if (gameObject.tag == "Bot")
            {
                BuildBot();
            StartCoroutine(Wait2S());
        }
            if (gameObject.tag == "Left")
            {
                BuildLeft();
            }
            if (gameObject.tag == "Right")
            {
                 BuildRight();
            StartCoroutine(Wait2S());
        }
      
    }
    private void BuildTop()
    {
        if (BinaryInteger == 1)
        {
             for (int i = 0; i < 1; i++)
             {  // Creer un couloir
            Instantiate(tunnel, new Vector3(transform.position.x, transform.position.y -2, transform.position.z), Quaternion.Euler(0, 0, 90),_Parent.transform);
            Instantiate(SouthRoom[SelectSouthRoom], new Vector3(transform.position.x, transform.position.y + Offset*2, transform.position.z), Quaternion.identity, _Parent.transform);
             }

        }
        if (BinaryInteger == 2)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnelCulDeSac, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 90), _Parent.transform);

                Instantiate(DeadEnd, new Vector3(transform.position.x, transform.position.y + (Offset / 2)*2, transform.position.z), Quaternion.Euler(0, 0, 90), _Parent.transform);
            }
        }
        if(BinaryInteger == 3)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnel, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Quaternion.Euler(0, 0, 90), _Parent.transform);
            }
        }
    }
    private void BuildBot()
    {
        if(BinaryInteger == 1)
        {// Construire une salle 
            for (int i = 0; i < 1; i++)
            { 
                Instantiate(tunnel, new Vector3(transform.position.x, transform.position.y +2, transform.position.z), Quaternion.Euler(0, 0, -90), _Parent.transform);           
                Instantiate(NorthRoom[SelectNorthRoom], new Vector3(transform.position.x, transform.position.y - Offset*2, transform.position.z), Quaternion.identity, _Parent.transform);

            }
        }
        if(BinaryInteger == 2)
        {// Construire un cul de sac
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnelCulDeSac, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -90), _Parent.transform);
                Instantiate(DeadEnd, new Vector3(transform.position.x, transform.position.y - (Offset / 2)*2, transform.position.z), Quaternion.Euler(0, 0, -90), _Parent.transform);

            }

        }
        if(BinaryInteger == 3)
        {// Ajouter un couloir
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnel, new Vector3(transform.position.x, transform.position.y -2, transform.position.z), Quaternion.Euler(0, 0, -90), _Parent.transform);
            }
        }
    }
    private void BuildLeft()
    {
        if (BinaryInteger == 1)
        {// Construire une salle et un couloir
            for (int i = 0; i < 1; i++)
            {  
                Instantiate(tunnel, new Vector3(transform.position.x +2, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -180), _Parent.transform);
               
                Instantiate(RightRoom[SelectRightRoom], new Vector3(transform.position.x - Offset*2, transform.position.y, transform.position.z), Quaternion.identity, _Parent.transform);
            }
        }
        if (BinaryInteger == 2)
        {// Construire un cul de sac
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnelCulDeSac, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 180), _Parent.transform);
             
                Instantiate(DeadEnd, new Vector3(transform.position.x - (Offset / 2)*2, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 180), _Parent.transform);
            }
        }
        if (BinaryInteger == 3)
        {// Construire un couloir
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnel, new Vector3(transform.position.x -2, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -180), _Parent.transform);
            }
        }
    }
    private void BuildRight()
    {
        if (BinaryInteger == 1)
        {// Construire une salle et un couloir
            for (int i = 0; i < 1; i++)
            {  
                Instantiate(tunnel, new Vector3(transform.position.x - 2, transform.position.y, transform.position.z), Quaternion.identity, _Parent.transform);
               
                Instantiate(LeftRoom[SelectLeftRoom], new Vector3(transform.position.x + Offset*2, transform.position.y, transform.position.z), Quaternion.identity, _Parent.transform);
            }
        }
        if (BinaryInteger == 2)
        {// Construire un cul de sac
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnelCulDeSac, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity, _Parent.transform);

                Instantiate(DeadEnd, new Vector3(transform.position.x + (Offset / 2)*2, transform.position.y, transform.position.z), Quaternion.identity, _Parent.transform);
            }
        }
        if (BinaryInteger == 3)
        {// Construire un couloir
            for (int i = 0; i < 1; i++)
            {
                Instantiate(tunnel, new Vector3(transform.position.x - 2, transform.position.y, transform.position.z), Quaternion.identity, _Parent.transform);
            }
        }
    }
    
    IEnumerator Wait2S()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}

