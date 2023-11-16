namespace Core.Data.Models;

public class Stomi
{
    public int ID { get; set; }
    public int StomiEjer { get; set; }
    public int StomiGiver { get; set; }
    public DateTime TilfoejetDen { get; set; }
}