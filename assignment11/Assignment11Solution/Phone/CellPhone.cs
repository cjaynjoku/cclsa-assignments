namespace Phone
{
    public class CellPhone:Phone, ICall, ITextMessage
    {
        public CellPhone(string name, string model) : base(name, model)
        {

        }

        public void MakeCall()
        {
            throw new System.NotImplementedException();
        }

        public void UseTextMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
