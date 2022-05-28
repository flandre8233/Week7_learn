using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputManagerListener : SingletonMonoBehavior<PlayerInputManagerListener>
{
    public List<PlayerInput> playerInputs;

    [SerializeField] SpherePlanet planet;
    [SerializeField] PlayerInputManager inputManager;
    public void OnPlayerJoined(PlayerInput playerInput)
    {
        GameObject PlayerGameObj = playerInput.gameObject;
        print("OnPlayerJoined : " + PlayerGameObj.name);
        PlayerGameObj.GetComponent<PlayerController>().PlayerLeftSide = (inputManager.playerCount <= 1);
        PlayerGameObj.GetComponent<PlanetStick>().planet = planet;
        PlayerGameObj.GetComponent<PlanetGrav>().planet = planet;

        PlayerGameObj.transform.position = PlanetSurfaceLZ.instance.GetAcceptableLZ();
        PlayerCheckerText.instance.UpdatePlayerTextView();

        PlayerGameObj.GetComponentInChildren<Waypoint>().IsLeftSide = (inputManager.playerCount <= 1);
        PlayerGameObj.GetComponent<Nitrogen>().BarView = HealthbarControll.instance.GetHealthbar((inputManager.playerCount <= 1));

        PlayerGameObj.GetComponent<PlayerController>().RunLock = true;

        playerInputs.Add(playerInput);

    }
    public void OnPlayerLeft(PlayerInput playerInput)
    {
        playerInputs.Remove(playerInput);

        print("OnPlayerLeft");
        PlayerCheckerText.instance.UpdatePlayerTextView();
    }

    public int GetPlayerNeedNumber()
    {
        return inputManager.maxPlayerCount - inputManager.playerCount;
    }
    public bool IsPlayerFull()
    {
        return GetPlayerNeedNumber() <= 0;
    }

    public void DestroyAllInputsObj()
    {
        for (int i = 0; i < playerInputs.Count; i++)
        {
            Destroy(playerInputs[i].gameObject);
        }
    }

    public void StartRun()
    {
        for (int i = 0; i < playerInputs.Count; i++)
        {
            playerInputs[i].gameObject.GetComponent<PlayerController>().RunLock = false;
        }
    }
}
