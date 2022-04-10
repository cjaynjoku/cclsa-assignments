namespace Phone
{
    public class SmartPhone:Phone, ICall, ITextMessage, ICamera, IVideo, IMMS, IEmail, IGames, IMessaging
    {
        public SmartPhone(string name, string model): base(name, model)
        {

        }

        public void MakeCall()
        {
            throw new System.NotImplementedException();
        }

        public void MakeVideo()
        {
            throw new System.NotImplementedException();
        }

        public void PlayGames()
        {
            throw new System.NotImplementedException();
        }

        public void SendMessage()
        {
            throw new System.NotImplementedException();
        }

        public void UseCamera()
        {
            throw new System.NotImplementedException();
        }

        public void UseEmail()
        {
            throw new System.NotImplementedException();
        }

        public void UseMMS()
        {
            throw new System.NotImplementedException();
        }

        public void UseTextMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
