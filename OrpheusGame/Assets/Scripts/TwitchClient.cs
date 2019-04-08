using System.Collections;
using System.Collections.Generic;
using TwitchLib.Client.Models;
using TwitchLib.Unity;
using UnityEngine;

public class TwitchClient : MonoBehaviour
{

    public Client client;
    private string channel_name = "Bob_Jone";
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;

        //set up bot and tell it which channel to join
        ConnectionCredentials credentials = new ConnectionCredentials("persephone_bot", Secrets.bot_access_token);
        client = new Client();
        client.Initialize(credentials, channel_name);

        //get bot to subscribe to events to listen to here later
        client.OnMessageReceived += MessageTestFunction;


        //connect bot
        client.Connect();
    }

    private void MessageTestFunction(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
    {
        Debug.Log(sender);
    }


    void ChordPickup()
    {
        client.SendMessage(client.JoinedChannels[0], "Placeholder message for chord pickup!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            client.SendMessage(client.JoinedChannels[0], "someone pressed 'B'");
        }
    }
}
