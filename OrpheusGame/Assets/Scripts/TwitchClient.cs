using System.Collections;
using System.Collections.Generic;
using TwitchLib.Client.Models;
using TwitchLib.Unity;
using UnityEngine;

public class TwitchClient : MonoBehaviour
{

    public Client client;
    private string channel_name = "bob_jone";
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;

        //set up bot and tell it which channel to join
        ConnectionCredentials credentials = new ConnectionCredentials("Persephone_Bot", Secrets.bot_access_token);
        client = new Client();
        client.Initialize(credentials, channel_name);

        //get bot to subscribe to events to listen to here later
        client.OnMessageReceived += SpeedUpTest;

        //connect bot
        client.Connect();
    }

    void SpeedUpTest(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
    {
        if (e.ChatMessage.Message == "fast")
        {
            Globals.instance.tempo = Globals.instance.tempo + 5;

            client.SendMessage(client.JoinedChannels[0], "Current tempo is: " + Globals.instance.tempo);
        }
    }


    void ChordPickup()
    {
        client.SendMessage(client.JoinedChannels[0], "Placeholder message for chord pickup!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
