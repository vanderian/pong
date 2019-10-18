using System;
using Api;
using Grpc.Core;
using UnityEngine;

namespace src.Client
{
    public class LeaderBoardApi : MonoBehaviour
    {
        public string serverIp = "http://localhost:5000";
        
        private Channel _channel;
        private LeaderBoard.LeaderBoardClient _client;

        public void Start()
        {
            CreateChannel();
            CreateClient();
        }

        public void CreateChannel()
        {
            _channel = new Channel(serverIp, ChannelCredentials.Insecure);
        }

        public void CreateClient()
        {
            if (_channel == null)
                return;

            try
            {
                _client = new LeaderBoard.LeaderBoardClient(_channel);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        public LeaderBoard.LeaderBoardClient GetClient()
        {
            return _client;
        }
    }
}