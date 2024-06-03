

namespace ModelsClassLibrary
{
    public class Insurance
    {
        public static readonly string INSERT = "INSERT INTO TB_INSURANCE (Description) VALUES (@Description); SELECT CAST(scope_identity() AS int)";

        public int Id { get; set; }
        public string Description { get; set; }
       
    }
}
