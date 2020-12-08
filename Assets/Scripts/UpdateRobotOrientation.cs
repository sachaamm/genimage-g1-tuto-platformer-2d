using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateRobotOrientation : MonoBehaviour
{
    GameObject platform;
    public GameObject robot;
    public Text orientationText;

    public MovePlayer MovePlayer;
    
    public enum Orientation
    {
        Top, // Platform_OnBottom
        Bottom, // Platform_OnTop
        Right, // Platform_OnLeft
        Left, // Platform_OnRight
    }

    public Orientation currentOrientation = Orientation.Top;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (platform != null)
        {
            // Mis à jour de l'orientation Uniquement quand on est "grounded"
            if (MovePlayer.IsGrounded())
            {
                currentOrientation = DetermineOrientation(platform);
            }
            else
            {
                currentOrientation = Orientation.Top;
            }
        }

        // orientationText.text = currentOrientation.ToString();
        
        UpdateOrientation();
    }
    
    // On va determiner la rotation du robot en fonction de l'orientation
    void UpdateOrientation(){

        switch (currentOrientation)
        {
            case Orientation.Top :
                robot.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
                break;
            
            case Orientation.Bottom :
                robot.transform.rotation = Quaternion.Euler(new Vector3(0,0,180));
                break;
            
            case Orientation.Left :
                robot.transform.rotation = Quaternion.Euler(new Vector3(0,0,90));
                break;
            
            case Orientation.Right :
                robot.transform.rotation = Quaternion.Euler(new Vector3(0,0,270));
                break;
                
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "platform" || 
            collision.transform.tag == "Untagged")
        {
            platform = collision.transform.gameObject;
            currentOrientation = DetermineOrientation(platform);

            
        }
    }

    Orientation DetermineOrientation(GameObject platform)
    {
        Bounds bounds = platform.GetComponent<SpriteRenderer>().bounds;
        Vector3 robotPos = transform.position;
        Vector3 platformPos = platform.transform.position;

        Vector3 boundsMax = bounds.max;
        Vector3 boundsMin = bounds.min;

        bool isOnBoundsMinRight = boundsMin.x < robotPos.x;
        bool isOnBoundsMaxRight = boundsMax.x < robotPos.x;
        
        bool isOnBoundsMinTop = boundsMin.y < robotPos.y;
        bool isOnBoundsMaxTop = boundsMax.y < robotPos.y;
        
        bool isInsideBoundsWidth = isOnBoundsMinRight && !isOnBoundsMaxRight;
        bool isInsideBoundsHeight = isOnBoundsMinTop && !isOnBoundsMaxTop;
        
        // Debug.Log("onMinRight " + isOnBoundsMinRight + " onMaxRight " + isOnBoundsMaxRight +
        //           "onMinTop " + isOnBoundsMinTop + " onMaxTop " + isOnBoundsMaxTop);
        //
        // Debug.Log("is inside bound width " + isInsideBoundsWidth +
        //            " is inside bound height " + isInsideBoundsHeight);
        
        if (isInsideBoundsWidth && !isInsideBoundsHeight)
        {
            // Comme il n'est pas dans la surface de la hauteur mais dans la surface de la largeur
            
            // Soit il est haut, soit il est en bas
            return robotPos.y > platformPos.y ? Orientation.Top : Orientation.Bottom;
            // Ternaire = condition ? valeurA : valeurB
            //      si la condition est vrai, alors Ternaire = valeurA
            //      sinon Ternaire = valeurB
        }

        if (!isInsideBoundsWidth && isInsideBoundsHeight)
        {
            return robotPos.x > platformPos.x ? Orientation.Right : Orientation.Left;
        }

        
        // On est obligés de renvoyés une valeur dans tous les cas.
        return Orientation.Top;
    }
    public Vector3 BulletSpawnPointOffset()
    {
        Vector3 offset = new Vector3();

        switch (currentOrientation)
        {
            case Orientation.Top:
                offset = new Vector3(0, 1, 0);
                break;

            case Orientation.Bottom:
                offset = new Vector3(0, -1, 0);
                break;
            case Orientation.Left:
                offset = new Vector3(-1, 0, 0);
                break;

            case Orientation.Right:
                offset = new Vector3(1, 0, 0);
                break;

        }
        return offset;
    }
}
