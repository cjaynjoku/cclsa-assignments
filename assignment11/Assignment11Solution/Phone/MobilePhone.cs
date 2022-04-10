namespace Phone
{
    public class MobilePhone:Phone, ICall, ITextMessage, ICamera, IVideo, IMMS
    {
        public MobilePhone(string name, string model) : base(name, model)
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

        public void UseCamera()
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
