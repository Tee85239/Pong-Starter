using Unity.Netcode;
using UnityEngine;

public class ClientMovement : NetworkBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Paddle paddle;
    

    private void Awake()
    {
        paddle.enabled = false;
    
    }

    // Update is called once per frame
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if (IsOwner)
        {
            paddle.enabled = true;
        }

        if (IsServer)
        {
           
        }
    }

    [Rpc(SendTo.Server)]
    private void UpdateInputServerRPC()
    {
        
    }


    }

