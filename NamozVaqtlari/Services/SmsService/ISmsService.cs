namespace NamozVaqtlari.Services.SmsService
{
    public interface ISmsService
    {
        int GenerateSmsCode();
        void SendSmsToPhoneNumber(string phoneNumber);  
    }
}
