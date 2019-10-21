using System;
using Grpc.Core;
using UnityEngine;

namespace Api
{
    public class PongApi : MonoBehaviour
    {
        public string serverIp = "127.0.0.1:5000";

        private Channel _channel;
        private PongApiService.PongApiServiceClient _client;

        public void Start()
        {
            CreateChannel();
            CreateClient();
        }

        private void CreateChannel()
        {
            _channel = new Channel(serverIp, ChannelCredentials.Insecure);
            Debug.Log("channel created");
        }

        private void CreateClient()
        {
            if (_channel == null)
                return;

            try
            {
                _client = new PongApiService.PongApiServiceClient(_channel);
                Debug.Log("client connected");
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        public PongApiService.PongApiServiceClient GetClient()
        {
            Debug.Log($"get client {_client}");
            return _client;
        }
    }
}