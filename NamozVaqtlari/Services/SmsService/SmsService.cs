namespace NamozVaqtlari.Services.SmsService
{
    public class SmsService : ISmsService
    {
        public int GenerateSmsCode()
        {
            Random rnd = new Random();
            int randomNumberInRange = rnd.Next(1000, 10000); 
            return randomNumberInRange;
        }

        public void SendSmsToPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
