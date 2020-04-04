namespace InterfaceSegregationPrincipleSample.Solution
{
    public interface IRegister
    {
        void Save();
    }

    public interface IEmail
    {
        void SendEmail();
    }
}
