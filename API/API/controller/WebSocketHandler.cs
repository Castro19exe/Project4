using System.Net.WebSockets;
using System.Text;

public class WebSocketHandler {
    public async Task HandleAsync(HttpContext context, WebSocket socket) {
        var buffer = new byte[1024];
        WebSocketReceiveResult result;

        do {
            result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
            // Handle received message (e.g., process it and send response) 
            var responseMessage = $"Received: {message}";
            var responseBytes = Encoding.UTF8.GetBytes(responseMessage);
            await socket.SendAsync(new ArraySegment<byte>(responseBytes),
            result.MessageType, result.EndOfMessage, CancellationToken.None);
        }
        while (!result.CloseStatus.HasValue);

        await socket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
    }
} 