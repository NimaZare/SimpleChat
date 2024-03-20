using SimpleChat.Client.Model;
using System.Net.Http.Json;

namespace SimpleChat.Client;

public partial class MainForm : Form
{
    private HttpClient http = new();
    private List<MessageModel> messages = [];
    private System.Windows.Forms.Timer timer;

    public MainForm()
    {
        InitializeComponent();
        timer = new()
        {
            Interval = 5000
        };
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        GetMessages();
    }

    private async void BtnSend_Click(object sender, EventArgs e)
    {
        await http.PostAsJsonAsync("https://localhost:7051/api/chats", new MessageModel { Sender = "Client", Message = txtMessage.Text });
        txtMessage.Text = string.Empty;
        txtMessage.Focus();
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        txtMessage.Text = string.Empty;
        txtMessage.Focus();
    }

    private async void GetMessages()
    {
        messages = await http.GetFromJsonAsync<List<MessageModel>>("https://localhost:7051/api/chats");
        lstChat.Items.Clear();
        foreach (var message in messages)
        {
            lstChat.Items.Add($"{message.Sender}: {message.Message} ({message.MessageDateTime:yyyy/MM/dd HH:mm})\n");
        }
        txtMessage.Focus();
    }
}
