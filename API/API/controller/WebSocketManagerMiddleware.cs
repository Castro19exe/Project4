﻿public class WebSocketManagerMiddleware {
    private readonly RequestDelegate _next;
    private readonly WebSocketHandler _webSocketHandler;

    public WebSocketManagerMiddleware(RequestDelegate next, WebSocketHandler webSocketHandler) {
        _next = next;
        _webSocketHandler = webSocketHandler;
    }

    public async Task InvokeAsync(HttpContext context) {
        if (!context.WebSockets.IsWebSocketRequest)
            return;

        var socket = await context.WebSockets.AcceptWebSocketAsync();

        await _webSocketHandler.HandleAsync(context, socket);
    }
}
