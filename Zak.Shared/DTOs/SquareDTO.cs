namespace Zak.Shared.DTOs;
public class SquareDTO
{
    public int Number { get; set; }
    public string Color { get; set; }
    public SquareDTO(int number, string color)
    {
        Number = number;
        Color = color;
    }
}