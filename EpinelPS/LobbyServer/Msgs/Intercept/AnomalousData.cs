using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Msgs.Intercept
{
    [PacketPath("/intercept/Anomalous/Data")]
    public class GetAnomalousData : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqInterceptAnomalousData>();

            var response = new ResInterceptAnomalousData
            {
                LastEnteredInterceptAnomalousId = 1,
                RemainingTickets = 5
            };
			response.ClearedInterceptAnomalousIds.Add(new[] { 1, 2, 3, 4, 5 });
            await WriteDataAsync(response);
        }
    }
}