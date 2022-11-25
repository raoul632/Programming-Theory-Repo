using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenemanager : MonoBehaviour
{

    public static Scenemanager Instance;

    [SerializeField] GameObject SlowlargeCargo;
    [SerializeField] GameObject SmallCargo;
    [SerializeField] GameObject FighterShip;
   
    GameObject actualPrincipalObject; 
 

    private void Awake()
    {

        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }
    [SerializeField]List<GameObject> allShipPart = new List<GameObject>(); 
    public Brocanteur brocanteur; 
    // Start is called before the first frame update
    void Start()
    {
        brocanteur = new Brocanteur(); 
        brocanteur.AddPartShip("ModuleCoc", allShipPart[0]);
        brocanteur.AddPartShip("ModuleCorps", allShipPart[1]);
        brocanteur.AddPartShip("ModuleCorpsTransporteur", allShipPart[2]);
        brocanteur.AddPartShip("ModulePropulseur1", allShipPart[3]);
        brocanteur.AddPartShip("ModulePropulseur2", allShipPart[4]);
        brocanteur.AddPartShip("ModulePropulseur4", allShipPart[5]);
        brocanteur.AddPartShip("ModuleMissile", allShipPart[6]);

       
    }

    public void AddLargeCargo()
    {
      
        if(actualPrincipalObject != null)
        {
            actualPrincipalObject.GetComponent<Ship>().DestroyShip(); 
            Destroy(actualPrincipalObject); 
        }
        actualPrincipalObject = Instantiate(SlowlargeCargo);
       actualPrincipalObject.GetComponent<Ship>().BuildShip(); 


    }

    public void AddSmallCargo()
    {
     
        if (actualPrincipalObject != null)
        {
           
            Destroy(actualPrincipalObject);
        }
        actualPrincipalObject = Instantiate(SmallCargo);
        actualPrincipalObject.GetComponent<Ship>().BuildShip();


    }

    public void AddFighterShip()
    {
      
        if (actualPrincipalObject != null)
        {
            
            Destroy(actualPrincipalObject);
        }
        actualPrincipalObject = Instantiate(FighterShip);
        actualPrincipalObject.GetComponent<Ship>().BuildShip();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
