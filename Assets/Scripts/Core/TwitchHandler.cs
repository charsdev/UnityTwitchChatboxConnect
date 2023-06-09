using System;
using System.Collections.Generic;
using UnityEngine;

namespace Chars.Tools
{
    public class TwitchHandler : MonoBehaviour
    {
        [SerializeField] private List<UnityEventString> _commandDictionary = new List<UnityEventString>();

        public void HandleTwitchMessage(string message)
        {
            Debug.Log("Twitch message received: " + message);

            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            string[] splitMessage = message.Split(':');

            if (splitMessage.Length >= 3)
            {
                string msg = splitMessage[2].Trim();
                print(msg);

                foreach (var command in _commandDictionary)
                {
                    if (msg.Equals(command.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        command.Event.Invoke();
                    }
                }
            }
        }
    }

}
