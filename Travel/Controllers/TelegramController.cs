namespace Travel.Controllers
{
    public class TelegramController
    {
        private static string url = "https://api.telegram.org/bot7049464662:AAFhipCgPhnf3ypV2UhzP1KroJWnr644o4U/sendMessage?chat_id=@kavsartourchat&parse_mode=html&text=";
        private static readonly HttpClient _httpClient = new HttpClient();
        public async Task SendMessages(string number, string username, string message)
        {
            try
            {
                var msg =
                    "Номер: " + number + "\n" +
                    "Ссылка: " + username + "\n" +
                    "Сообщение: " + message + "\n";
                var response = await _httpClient.GetAsync(url + msg);
                var answer = response.EnsureSuccessStatusCode();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"error: {ex.Message}\nstacktrace: {ex.StackTrace}");
            }
        }
    }
}
