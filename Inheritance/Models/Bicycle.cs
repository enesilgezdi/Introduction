

namespace Inheritance.Models;

public sealed class Bicycle : Vehicle
{
    public bool IsAmortisor { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} VitesTipi: {TransmissionType} Renk : {Color} Amorsitor : {IsAmortisor}";
    }

}
