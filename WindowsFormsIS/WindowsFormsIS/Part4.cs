using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsIS
{
    public partial class Part4 : Form
    {
        private ClientWebSocket _clientWebSocket;
        public Part4()
        {
            InitializeComponent();
        }

        private async void BtnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                _clientWebSocket = new ClientWebSocket(); //cria uma instância de ClientWebSocket


                await _clientWebSocket.ConnectAsync(new Uri("ws://localhost:5000/ws"), CancellationToken.None); //estabelece uma conexão com o servidor WebSocket em ws://localhost:5000/ws

                _ = ReceiveMessagesAsync(); //Inicia a receção de mensagens chamando o método ReceiveMessagesAsync()

                btnConnection.Enabled = false; //desabilita o botão de conexão após estabelecimento de conexão
                textBoxConnection.Enabled = true; //habilita a caixa de mensagem de entrada após estabelecimento de conexão
                btnSend.Enabled = true; // habilita o botão de envio após estabelecimento de conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na conexão: {ex.Message}");
            }
        }

        private async Task ReceiveMessagesAsync() //responsável por receber mensagens do servidor WebSocket enquanto a conexão estiver aberta
        {
            var buffer = new byte[1024];
            while (_clientWebSocket.State == WebSocketState.Open) //aguarda até que o estado da conexão seja aberto
            {
                var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None); //chama ReceiveAsync() para receber uma mensagem do servidor
                var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                //converte os dados numa string UTF-8
                textBoxSend.Text = message; //atualiza a caixa de texto txtReceivedMessage com a mensagem recebida
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (_clientWebSocket.State == WebSocketState.Open) //verifica se a conexão WebSocket está aberta
            {
                var message = Encoding.UTF8.GetBytes(textBoxConnection.Text); // converte o texto da caixa txtMessage.Text em bytes UTF-8
                await _clientWebSocket.SendAsync(new ArraySegment<byte>(message), WebSocketMessageType.Text, true, CancellationToken.None); //envia a mensagem para o servidor usando SendAsync()
                textBoxConnection.Text = ""; // limpa o conteúdo da caixa de mensagem de entrada
            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main();
            this.Hide();
            mainPage.Show();
        }
    }
}
