namespace FabricMethodPattern
{
    internal class BMW : IAuto
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void TurnOn()
        {
            throw new System.NotImplementedException();
        }

        public void TurnOff()
        {
            throw new System.NotImplementedException();
        }
    }
}