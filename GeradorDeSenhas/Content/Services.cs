using Content.Services;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;


namespace GeradorDeSenhas.Content
{
    public class Services
    {
        private string? FullUrl = "";
        private readonly string newLine = Environment.NewLine + Environment.NewLine;
       
        private HttpResponseMessage responseMessage = new();
        private readonly PasswordGenerator randomPassword = new();
        private readonly TicketString ticketString = new();

        private StringBuilder? Password { get; set; }
        private decimal NumberOfDaysToExpire { get; set; }
        private decimal NumberOfViewsToExpire { get; set; }
        private decimal PasswordSize { get; set; }
        private decimal NumberOfPasswords { get; set; }
        private TextBox TextBoxValues { get; set; }
        
        public Services(StringBuilder password, decimal numberOfDaysToExpire, decimal numberOfViewsToExpire, decimal passwordSize, decimal numberOfPasswords, TextBox textBoxValues)
        {
            Password = password;
            NumberOfDaysToExpire = numberOfDaysToExpire;
            NumberOfViewsToExpire = numberOfViewsToExpire;
            PasswordSize = passwordSize;    
            TextBoxValues = textBoxValues;
            NumberOfPasswords = numberOfPasswords;           
        }      
      
        private async Task PostPassAsync()
        {
            using var httpClient = new HttpClient();
            using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://pwpush.com/p.json");

            request.Headers.TryAddWithoutValidation("X-User-Email", "silasbramos@outlook.com");
            request.Headers.TryAddWithoutValidation("X-User-Token", "X8dt8Vr4y44s8xHi7-qB");

            request.Content = new StringContent($"password[payload]={randomPassword.GetPassword}&password[expire_after_days]={NumberOfDaysToExpire}&password[expire_after_views]={NumberOfViewsToExpire}");
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

            responseMessage = await httpClient.SendAsync(request);

            if (!responseMessage.IsSuccessStatusCode)
                MessageBox.Show("Erro ao requisitar senha, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task<string> GetPassAsync()
        {
            string data = await responseMessage.Content.ReadAsStringAsync();
            dynamic? deserializeJson = JsonConvert.DeserializeObject(data);

            string? urlCode = deserializeJson?.url_token;
            string url = "https://pwpush.com/p/";
            FullUrl = url + urlCode;

            if (urlCode == null)
                MessageBox.Show("Erro ao gerar senha, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return FullUrl;
        }
            
        public async void NewNumberPassword()
        {
            TextBoxValues.Clear();

            if (NumberOfPasswords == 1)
            {
                randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                await PostPassAsync();
                await GetPassAsync();
                TextBoxValues.AppendText(randomPassword.GetPassword + Environment.NewLine + FullUrl);
            }
            else if (NumberOfPasswords > 1)
            {
                for (int i = 0; i < NumberOfPasswords; i++)
                {
                    randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(randomPassword.GetPassword + Environment.NewLine + FullUrl + newLine);
                    
                }
            }

        }
      
        public async void NewNumberAndSpecialPassword()
        {
            TextBoxValues.Clear();

            if (NumberOfPasswords == 1)
            {
                randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                await PostPassAsync();
                await GetPassAsync();
                TextBoxValues.AppendText(randomPassword.GetPassword + Environment.NewLine + FullUrl);
            }
            else if (NumberOfPasswords > 1)
            {
                for (int i = 0; i < NumberOfPasswords; i++)
                {
                    randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(randomPassword.GetPassword + Environment.NewLine + FullUrl + newLine);
                }
            }

        }

        public async void PasswordTicketResetPortuguese(CheckBox checkBox)
        {
            TextBoxValues.Clear();

            if(checkBox.Checked == true)
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderString().ToString());
                    randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterString());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderString().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterString().ToString() + newLine);
                }
            } 
            else
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderString().ToString());
                    randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterString());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderString().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterString().ToString() + newLine);
                }
            }
                
           
        } 
        
        public async void PasswordTicketResetSpanish(CheckBox checkBox)
        {
            TextBoxValues.Clear();

            if(checkBox.Checked == true)
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderStringSpanish().ToString());
                    randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterStringSpanish());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderStringSpanish().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterStringSpanish().ToString() + newLine);
                }
            } 
            else
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderStringSpanish().ToString());
                    randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterStringSpanish());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.ResetHeaderStringSpanish().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterStringSpanish().ToString() + newLine);
                }
            }                   
        }
      
        public async void PasswordTicketCreatePortuguese(CheckBox checkBox)
        {
            TextBoxValues.Clear();

            if(checkBox.Checked == true)
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderString().ToString());
                    randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterString());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderString().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterString().ToString() + newLine);
                }
            } 
            else
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderString().ToString());
                    randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterString());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderString().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterString().ToString() + newLine);
                }
            }
                
           
        } 
        
        public async void PasswordTicketCreateSpanish(CheckBox checkBox)
        {
            TextBoxValues.Clear();

            if(checkBox.Checked == true)
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderStringSpanish().ToString());
                    randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterStringSpanish());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderStringSpanish().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithSpecialAndNumberCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterStringSpanish().ToString() + newLine);
                }
            } 
            else
            {
                if (NumberOfPasswords == 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderStringSpanish().ToString());
                    randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                    await PostPassAsync();
                    await GetPassAsync();
                    TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString() + ticketString.FooterStringSpanish());

                }
                else if (NumberOfPasswords > 1)
                {
                    TextBoxValues.AppendText(ticketString.CreateHeaderStringSpanish().ToString());
                    for (int i = 0; i < NumberOfPasswords; i++)
                    {
                        randomPassword.GenerateWithNumbersCharacters(PasswordSize);
                        await PostPassAsync();
                        await GetPassAsync();
                        TextBoxValues.AppendText(ticketString.MiddleString(FullUrl, randomPassword.GetPassword.ToString()).ToString());
                    }
                    TextBoxValues.AppendText(ticketString.FooterStringSpanish().ToString() + newLine);
                }
            }
                
           
        }

    }
}

