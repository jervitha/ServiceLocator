using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Utilities;
using ServiceLocator.Player;
using ServiceLocator.Sound;
public class GameService : GenericMonoSingleton<GameService>
{
    public PlayerService playerService { get; private set; }
    public SoundService soundService { get; private set; }
    [SerializeField] public PlayerScriptableObject playerScriptableObject;
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private AudioSource audioEffects;
    [SerializeField] private AudioSource backgroundMusic;


    private void Start()
    {
        playerService = new PlayerService(playerScriptableObject);
        soundService = new SoundService(soundScriptableObject,audioEffects,backgroundMusic);
    }

   public void Update()
    {
        playerService.Update();
    }
}
